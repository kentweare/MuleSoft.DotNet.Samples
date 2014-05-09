using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MuleSoft.DotNet.BusinessLogic
{
    //Data contract used as a return value in our Business Logic and also as a request object in our
    //General Ledger Service. 
    [DataContract]
    public class TimeSheetForGL
    {
         [DataMember]
        public string EmployeeID { get; set; }

        [DataMember]
        public int MachineID { get; set; }

        [DataMember]
        public string PlantName { get; set; }

         [DataMember]
        public double Cost { get; set; }
         [DataMember]
        public string CostCenter { get; set; }
         [DataMember]
        public string Department { get; set; }
    }
}