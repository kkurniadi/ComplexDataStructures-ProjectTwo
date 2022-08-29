using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
// Kirsten Kurniadi, ID: 30045816
// Date: 29/08/2022
// A program to test the AstroMath DLL
namespace MathTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate class library
            Astro astro = new Astro();
            // Test the Star Velocity function
            Console.WriteLine("Input observed wavelength:");
            double observed = double.Parse(Console.ReadLine());
            Console.WriteLine("Input rest wavelength:");
            double rest = double.Parse(Console.ReadLine());
            double sv = astro.StarVelocity(observed, rest);
            Console.WriteLine("Star velocity is: " + sv + " m/s");
            Console.ReadLine();
            // Test the Star Distance function
        }
    }
}
