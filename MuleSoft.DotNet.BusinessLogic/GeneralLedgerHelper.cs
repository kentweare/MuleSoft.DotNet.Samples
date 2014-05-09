using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuleSoft.DotNet.BusinessLogic
{
    public class GeneralLedgerHelper
    {
        //This method has been created to simulate
        //some business logic.  Nother earth shattering in here.
        public TimeSheetForGL  PreProcessTimeSheetForGL(TimeSheet ts)
        {
            TimeSheetForGL tsfg = new TimeSheetForGL();

            //Copy data from incoming TimeSheet
            tsfg.Cost = ts.Cost;
            tsfg.EmployeeID = ts.EmployeeID;
            tsfg.PlantName = ts.PlantName;
            tsfg.MachineID = ts.MachineID;

            //Assemble Data for GL
            //Cost Center
	        switch ( tsfg.PlantName )
	        {
	            case "New Mexico":
		            tsfg.CostCenter = "1001";
		            break;
	            case "California":
		            tsfg.CostCenter = "1002";
		            break;
                case "Arizona":
                    tsfg.CostCenter = "1003";
                    break;
                case "Texas":
                    tsfg.CostCenter = "1004";
                    break;
	        }

            //Department
            if(tsfg.MachineID>= 1000000 && tsfg.MachineID <2000000)
                 tsfg.Department ="9000";
            else if(tsfg.MachineID>= 2000000 && tsfg.MachineID <3000000)
                tsfg.Department = "9001";
            else if(tsfg.MachineID>= 3000000 && tsfg.MachineID <4000000)
                tsfg.Department = "9002";
            else if (tsfg.MachineID >= 4000000 && tsfg.MachineID < 5000000)
                 tsfg.Department = "9003";

            return tsfg;
        }
    }
}
