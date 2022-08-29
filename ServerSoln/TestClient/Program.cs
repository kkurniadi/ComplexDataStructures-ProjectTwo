using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
// Kirsten Kurniadi, ID: 30045816
// Date: 29/08/2022
// Console-based client program for testing purposes
namespace TestClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a separate console client with test data to establish connectivity and test the basic functionality of the server.
            // Include code into final Server Solution Folder.
            Console.WriteLine("Client started");
            ChannelFactory<IAstroContract> pipeFactory = new ChannelFactory<IAstroContract>(
                new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/AstroServer"));
            IAstroContract pipeProxy = pipeFactory.CreateChannel();

            while (true)
            {
                double d1 = double.Parse(Console.ReadLine());
                double d2 = double.Parse(Console.ReadLine());
                Console.WriteLine("pipe: " + pipeProxy.StarVelocity(d1, d2));
            }
        }
    }
}
