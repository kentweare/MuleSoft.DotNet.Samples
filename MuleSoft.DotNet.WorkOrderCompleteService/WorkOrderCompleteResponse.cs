using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MuleSoft.DotNet.WorkOrderCompleteService
{
    [DataContract]
    public class WorkOrderCompleteResponse
    {
        [DataMember]
        public string WorkOrderID { get; set; }

        [DataMember]
        public bool isAcknowledged { get; set; }
    }
}
