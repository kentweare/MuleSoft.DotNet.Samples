using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuleSoft.DotNet.BusinessLogic;

namespace MuleSoft.DotNet.GeneralLedgerService
{

    //Service Implementation Class/Method
    public class GeneralLedgerService:IGeneralLedgerService
    {

        //Not much going on here.  Receive a request, take the Employee ID and 
        //include it in the response object
        public TimeSheetForGLResponse ProcessGL(TimeSheetForGL gl)
        {

            Console.WriteLine(String.Format("GL Response received for Employee {0}",gl.EmployeeID));
            TimeSheetForGLResponse response = new TimeSheetForGLResponse();
            response.EmployeeID = gl.EmployeeID;
            response.Status = true;
            Console.WriteLine("Acknowledgment being prepared");
            return response;
        }
    }
}
