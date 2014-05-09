using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace MuleSoft.DotNet.MaintenanceSystem
{
    public partial class Form1 : Form
    {
        //Enter Queue Names here
        //Note the account that is running Visual Studio, or compiled app
        //will require the appropriate permissions
        //This link will provide some insight http://blogs.msdn.com/b/johnbreakwell/archive/2009/08/03/default-msmq-queue-permissions-have-changed-in-msmq-4-0.aspx
        private const string _msgQRec = ".\\Private$\\workordersoutbound";
        private const string _msgQSend = ".\\private$\\workorderinbound";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageQueue msgQ = new MessageQueue(_msgQRec);

           

            System.Messaging.Message m = new System.Messaging.Message();
            m.Formatter = new XmlMessageFormatter(new Type[] { typeof(String) });

            try
            {
                //When we pull the message off from the queue it will be in the form of a 
                //byte array
                m = msgQ.Receive();
                byte[] data = new byte[1024];
                m.BodyStream.Read(data, 0, 1024);
                string strMessage = ASCIIEncoding.ASCII.GetString(data);
                
                //load message into XmlDocument
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(strMessage);
             
                //Deserialize Xml Document into a typed C# object  
                var ser = new XmlSerializer(typeof(WorkOrderRequests));
                var wo = (WorkOrderRequests)ser.Deserialize(new StringReader(xml.OuterXml));
               
                //Populate our GUI
                txtFunctionalLocation.Text = wo.WorkOrderRequest[0].FunctionalLocation;
                txtMachineID.Text = wo.WorkOrderRequest[0].MachinedID;
                txtMaintenanceType.Text = wo.WorkOrderRequest[0].MaintenanceType;
                txtPlant.Text = wo.WorkOrderRequest[0].Plant;
                txtRequestedDate.Text = wo.WorkOrderRequest[0].RequestDate.ToString();
                txtWorkOrderID.Text = wo.WorkOrderRequest[0].WorkOrderID;

                btnCompleteWorkOrder.Visible = true;

                msgQ.Close();
                msgQ.Dispose();  
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("An exception has occurred {0}", ex.ToString()));
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCompleteWorkOrder_Click(object sender, EventArgs e)
        {

            //Hiding UI elements
            panelCompleteWorkOrder.Visible = true;
            btnCompleteWorkOrder.Visible = false;
            btnSubmitCompletedWorkOrder.Visible = true;
            txtCompleteWorkOrderID.Text = txtWorkOrderID.Text; 
        }


        private void btnSubmitCompletedWorkOrder_Click(object sender, EventArgs e)
        {

            //Populate Work Order Object so that it can be placed on our MSMSQ
            int hours = 0;
            WorkOrderCompletionRequests wo = new WorkOrderCompletionRequests();
            WorkOrderCompletionRequestsWorkOrderCompletionRequest woreq = new WorkOrderCompletionRequestsWorkOrderCompletionRequest();
            woreq.Comments = txtComments.Text;
            Int32.TryParse(txtCompleteHours.Text,out hours);
            woreq.Hours = hours;
            if(checkYes.Checked )
            {
                woreq.IsSuccessful = true;
            }
            else
            {
                woreq.IsSuccessful = false;
            }
            woreq.WorkOrderId = txtCompleteWorkOrderID.Text; 
            wo.WorkOrderCompletionRequest = new WorkOrderCompletionRequestsWorkOrderCompletionRequest();
            wo.WorkOrderCompletionRequest = woreq;

            MessageQueue msgQSend = new MessageQueue(_msgQSend);
          
            msgQSend.Send(wo); 


        }
    }
}

