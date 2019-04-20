using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using WcfServiceContract;

namespace WcfServiceHost
{
    class Program
    {
        public static string BASE_NAME = "Calculator";
        public static int PORT = 9001;

        static void Main(string[] args)
        {
            Uri baseAddress = new Uri($"http://localhost:{PORT}/{BASE_NAME}");

            ServiceHost host = new ServiceHost(typeof(Calculator), baseAddress);

            try
            {
                WSHttpBinding httpBinder = new WSHttpBinding();
                host.AddServiceEndpoint(typeof(ICalculator), httpBinder, "ENDPOINT_1");

                ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                smb.HttpGetEnabled = true;
                host.Description.Behaviors.Add(smb);

                host.Open();
                Console.WriteLine("Service started running...");
                Console.WriteLine("Press <ENTER> to finish");
                Console.WriteLine();
                Console.ReadLine();
                host.Close();
            } catch (CommunicationException e)
            {
                Console.WriteLine($"Encountered error: {e}");
            }
        }
    }
}
