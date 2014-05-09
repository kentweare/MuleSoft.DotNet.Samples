using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This is the TimeSheet object used as an input to our Business logic funtion

namespace MuleSoft.DotNet.BusinessLogic
{
    public class TimeSheet
    {

        public string EmployeeID { get; set; }

       
        public int MachineID { get; set; }

       
        public string PlantName { get; set; }

        
        public double Cost { get; set; }
    }
}
