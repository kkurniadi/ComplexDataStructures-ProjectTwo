using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
// Kirsten Kurniadi, ID: 30045816
// Date: 29/08/2022
// A program that provides connection to client(s)
namespace Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer),
                new Uri[]
                {
                    new Uri("net.pipe://localhost")
                }))
            {
                host.AddServiceEndpoint(typeof(IAstroContract),
                    new NetNamedPipeBinding(), "AstroServer");
                host.Open();
                Console.WriteLine("Service is available. " + "Press <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }
        }
    }
}
