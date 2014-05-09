using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuleSoft.DotNet.WorkOrderCompleteService
{
    public class WorkOrderCompletion: IWorkOrderCompletion
    {

        //Web Method
        //Receive a Work Order Requet and provide a Work Order response with a simple acknowledgement.
        public WorkOrderCompleteResponse CompleteWorkOrder(WorkOrderCompleteRequest wo)
        {
            Console.WriteLine(String.Format("Work Order {0} has been received", wo.WorkOrderID));
            Console.WriteLine("Assembling Response to service caller");

            WorkOrderCompleteResponse response = new WorkOrderCompleteResponse
            {
                isAcknowledged =true,
                WorkOrderID = wo.WorkOrderID
            };

            Console.WriteLine("Sending Web Service Response");

            return response;
        }
    }
}
