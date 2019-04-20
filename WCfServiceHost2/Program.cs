using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using WcfServiceContract;

namespace WCfServiceHost2
{
    class Program
    {

        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Calculator));
            ArrayList endpoints = new ArrayList();
            try
            {
                Uri tcpAddress = new Uri("net.tcp://localhost:30000/CalculatorTCP");
                endpoints.Add(host.Description.Endpoints.Find(typeof(ICalculator)));
                endpoints.Add(host.Description.Endpoints.Find(new Uri("http://localhost:9001/Calculator/endpoint2")));
                endpoints.Add(host.Description.Endpoints.Find(new Uri("http://localhost:9002/Calculator/endpoint3")));
                endpoints.Add(host.AddServiceEndpoint(typeof(ICalculator), new NetTcpBinding(), tcpAddress));

                Console.WriteLine("\n---> Endpoints: ");
                foreach (ServiceEndpoint se in endpoints)
                {
                    Console.WriteLine($"\nService endpoint {se.Name}: ");
                    Console.WriteLine($"Binding: {se.Binding.ToString()}");
                    Console.WriteLine($"ListenUri: {se.ListenUri.ToString()}");
                }

                host.Open();
                Console.WriteLine("\n--> Service 1 started running...");

                Console.WriteLine("Contract information: ");

                ContractDescription desc = ContractDescription.GetContract(typeof(ICalculator));
                Console.WriteLine($"\t Contract type: {desc.ContractType.ToString()}");
                Console.WriteLine($"\t Contract name: {desc.Name}");
                Console.WriteLine("\tOperations: ");

                foreach (OperationDescription od in desc.Operations)
                {
                    Console.WriteLine($"\t\t {od.Name}");
                }

                Console.WriteLine("\n\n--> Press <ENTER> to exit.");
                Console.WriteLine();
                Console.ReadLine();

                host.Close();
            } catch (CommunicationException e)
            {
                Console.WriteLine($"Encountered exception: {e}");
                host.Abort();
            }
        }
    }
}
