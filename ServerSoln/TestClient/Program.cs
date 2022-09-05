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
            bool running = true;

            while (running)
            {
                Console.WriteLine("To calculate star velocity, enter 'V'");
                Console.WriteLine("To calculate star distance, enter 'D'");
                Console.WriteLine("To calculate temperature in Kelvin, enter 'K'");
                Console.WriteLine("To calculate event horizon, enter 'H'");
                Console.WriteLine("To exit, enter 'Q'");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "V":
                        Console.WriteLine("Enter observed wavelength:");
                        double d1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter rest wavelength:");
                        double d2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("pipe: " + pipeProxy.StarVelocity(d1, d2));
                        break;
                    case "D":
                        Console.WriteLine("Enter parallax angle");
                        double angle = double.Parse(Console.ReadLine());
                        Console.WriteLine("pipe: " + pipeProxy.StarDistance(angle));
                        break;
                    case "K":
                        Console.WriteLine("Enter temperature in Celsius");
                        double temp = double.Parse(Console.ReadLine());
                        Console.WriteLine("pipe: " + pipeProxy.TempInKelvin(temp));
                        break;
                    case "H":
                        Console.WriteLine("Enter blackhole mass");
                        double mass = double.Parse(Console.ReadLine());
                        Console.WriteLine("pipe: " + pipeProxy.EventHorizon(mass));
                        break;
                    case "Q":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again");
                        break;
                }
            }
        }
    }
}
