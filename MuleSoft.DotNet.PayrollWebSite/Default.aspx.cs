using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MuleSoft.DotNet.PayrollWebSite; 

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //Default location of web service is http://localhost:8083/ProcessTimeSheet
        //Modify web.config to change it
        //Construct Web Service Request
        TimeSheet.TimeSheetServiceClient client = new TimeSheet.TimeSheetServiceClient();
        TimeSheet.timeSheetResponse response;
        TimeSheet.timeSheetRequest request = new TimeSheet.timeSheetRequest { 
            cost = System.Convert.ToDouble(txtCost.Text),
            employeeID = txtEmployeeID.Text,
            machineID = System.Convert.ToInt32(txtMachineID.Text),
            plantName = txtPlantName.Text
        };

        response = client.ProcessTimeSheet(request);

        if(response.status)
        {
            txtStatus.Text = "Processed";
            txtStatus.ForeColor = System.Drawing.Color.Green;
        }
        
    }
}