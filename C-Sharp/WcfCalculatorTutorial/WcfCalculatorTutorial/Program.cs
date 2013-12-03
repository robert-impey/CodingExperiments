using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel.Description;
using System.ServiceModel;

namespace Microsoft.ServiceModel.Samples
{
    /// <summary>
    /// A service for arithmetic.
    /// 
    /// You need to run CMD as Admin and run:
    /// netsh http add urlacl url=http://+:8000/ServiceModelSamples/Service user=DOMAIN\User
    /// 
    /// For this to work.
    /// 
    /// Check that the URL has been reserved for you with:
    /// 
    /// netsh http show urlacl
    /// 
    /// Tidy up after yourself with:
    /// netsh http delete urlacl url=http://+:8000/ServiceModelSamples/Service
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var baseAddress = new Uri("http://localhost:8000/ServiceModelSamples/Service");
            var selfHost = new ServiceHost(typeof(Calculator), baseAddress);

            try
            {
                selfHost.AddServiceEndpoint(
                    typeof(ICalculator),
                    new WSHttpBinding(),
                    "CalculatorService"
                );

                // Step 4 of the hosting procedure: Enable metadata exchange.
                var smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                selfHost.Description.Behaviors.Add(smb);

                // Step 5 of the hosting procedure: Start (and then stop) the service.
                selfHost.Open();
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press <ENTER> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                // Close the ServiceHostBase to shutdown the service.
                selfHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                selfHost.Abort();
            }
        }
    }
}
