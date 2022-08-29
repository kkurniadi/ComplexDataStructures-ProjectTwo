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
            double sv = astro.StarVelocity(500.1, 500);
            Console.WriteLine("Star velocity is: " + sv + " m/s");
            Console.ReadLine();
        }
    }
}
