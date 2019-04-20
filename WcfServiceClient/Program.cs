using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceClient.CalculatorReference;

namespace WcfServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculatorClient client = new CalculatorClient();
            List<CalculatorClient> clientList = new List<CalculatorClient>
            {
                new CalculatorClient("ENDPOINT_1"),
                new CalculatorClient("ENDPOINT_2"),
                new CalculatorClient("ENDPOINT_3"),
                new CalculatorClient("NetTcpBinding_ICalculator")
            };

            double fst = 5.0;
            double snd = 2.0;
            double n = 25.0;

            for(int i = 0; i < clientList.Count; i++)
            {
                Console.WriteLine($"---------[CLIENT NUMBER {i}]------------");
                RunClient(clientList[i], fst, snd, n, i + 1);
                clientList[i].Close();
            }
        }

        static void RunClient(CalculatorClient client, double fst, double snd, double n, double second_n)
        {
            double sum_result = client.sumPerm(n);
            sum_result = client.sumPerm(second_n);
            Console.WriteLine($"Addition: {fst} + {snd} = {client.add(fst, snd)}");
            Console.WriteLine($"Subtraction: {fst} - {snd} = {client.sub(fst, snd)}");
            Console.WriteLine($"Multiplication: {fst} * {snd} = {client.mult(fst, snd)}");
            Console.WriteLine($"Division: {fst} / {snd} = {client.div(fst, snd)}");
            Console.WriteLine($"SUM: {sum_result}");
        }
    }
}
