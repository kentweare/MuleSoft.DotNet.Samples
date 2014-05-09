using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MuleSoft.DotNet.BusinessLogic
{
    //Simple acknowledgement response from the General Ledger Service
    [DataContract]
    public class TimeSheetForGLResponse
    {
         [DataMember]
        public String EmployeeID { get; set; }

         [DataMember]
        public bool Status { get; set; }
    }
}
