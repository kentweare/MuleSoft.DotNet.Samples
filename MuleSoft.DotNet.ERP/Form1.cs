using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MuleSoft.DotNet.ERP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWorkOrder.Text = "1000304";
            txtRequestDate.Text = DateTime.Now.Date.ToString("yyyy-MM-dd"); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WorkOrder.ProcessWorkOrderClient  client = new WorkOrder.ProcessWorkOrderClient();
            
            WorkOrder.workOrderRequest wo = new WorkOrder.workOrderRequest();
            wo.functionalLocation = cmbFunctionalLocation.SelectedItem.ToString() ;
            wo.machineID = System.Convert.ToInt32(cmbMachine.SelectedItem);
            wo.maintenanceType = cmbMainType.SelectedItem.ToString();
            wo.plant = cmbPlant.SelectedItem.ToString();
            DateTime requestDate;
            DateTime.TryParse(txtRequestDate.Text, out requestDate);
            wo.requestDate = requestDate;
            wo.workOrderID = txtWorkOrder.Text;

            WorkOrder.workOrderRequestAck ack = client.ProcessWorkOrder(wo);

            MessageBox.Show(String.Format("Work Order {0} has been send successfully {1}", ack.workOrderID, ack.status));  

         
        }
    }
}
