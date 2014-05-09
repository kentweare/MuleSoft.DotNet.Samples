using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using MuleSoft.DotNet.BusinessLogic;

namespace MuleSoft.DotNet.GeneralLedgerService
{

    
    class Program
    {
        //Note this Service has a reference to the MuleSoft.DotNet.BusinessLogic
        //Assembly as there are some shared contracts.


        //This is a Self hosted WCF service that will also expose a MEX Endpoint aka WSDL
        const string _WebServiceURL = "http://localhost:8085/GeneralLedgerService";


        static void Main(string[] args)
        {
             
            Uri baseAddress = new Uri("_WebServiceURL");

            // Create the ServiceHost.
            using (ServiceHost host = new ServiceHost(typeof(GeneralLedgerService), baseAddress))
            {


                // Enable metadata publishing.
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                host.Description.Behaviors.Add(smb);

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
