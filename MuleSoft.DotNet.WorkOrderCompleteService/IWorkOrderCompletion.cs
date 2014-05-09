using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MuleSoft.DotNet.WorkOrderCompleteService
{

   [ServiceContract]
    [XmlSerializerFormat]
    public interface IWorkOrderCompletion
    {
        [OperationContract]
        WorkOrderCompleteResponse CompleteWorkOrder(WorkOrderCompleteRequest wo);
    }
}
