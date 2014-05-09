using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace MuleSoft.DotNet.WorkOrderCompleteService
{


 
    class Program
    {
        //This is a Self hosted WCF service that will also expose a MEX Endpoint aka WSDL
        const string _WebServiceURL = "http://localhost:8082/WorkOrderCompletion";
        static void Main(string[] args)
        {
            //Self hosted WCF Service - 
            Uri baseAddress = new Uri(_WebServiceURL);

            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(WorkOrderCompletion), baseAddress))
            {

                
                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

                Console.WriteLine("Starting Service"); 

                // Open the ServiceHost to start listening for messages. Since
                // no endpoints are explicitly configured, the runtime will create
                // one endpoint per base address for each service contract implemented
                // by the service.
                host.Open();

                Console.WriteLine("The service is ready at {0}", baseAddress);
                Console.WriteLine("Press <Enter> to stop the service.");
                Console.ReadLine();

                // Close the ServiceHost.
                host.Close();
            }
        }
    }
}
