using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MuleSoft.DotNet.WorkOrderCompleteService
{
  [DataContract]
    public class WorkOrderCompleteRequest
    {

            [DataMember]
            public string WorkOrderID { get; set; }

             [DataMember]
            public int Hours { get; set; }
            
            [DataMember]
            public bool isSuccessful { get; set; }

            [DataMember]      
             public string Comments { get; set; }
        
    }
}
