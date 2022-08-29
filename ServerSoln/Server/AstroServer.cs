using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;
// Kirsten Kurniadi, ID: 30045816
// Date: 29/08/2022
// A class that implements the IAstroContract interface
namespace Server
{
    internal class AstroServer : IAstroContract
    {
        // 6.2.	Create the server file called “AstroServer.cs” which implements the IAstroContract.
        // Add a new instance of the class library method and then create four methods with the suitable input parameters and return types.
        Astro astro = new Astro();
        public double StarVelocity(double d1, double d2)
        {
            return astro.StarVelocity(d1, d2);
        }
        public double StarDistance(double d)
        {
            return astro.StarDistance(d);
        }
        public double TempInKelvin(double d)
        {
            return astro.TempInKelvin(d);
        }
        public double EventHorizon(double d)
        {
            return astro.EventHorizon(d);
        }
    }
}
