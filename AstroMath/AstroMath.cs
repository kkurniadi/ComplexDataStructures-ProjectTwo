using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    public class AstroMath
    {
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            double delta = observedWavelength - restWavelength;
            double velocity = 2999792458 * (delta / restWavelength);
            return velocity;
        }
        public double StarDistance(double parallaxAngle)
        {
            double distance = 1 / parallaxAngle;
            return distance;
        }
        public double TempInKelvin(double celsius)
        {
            double kelvin = celsius + 273;
            return kelvin;
        }
        public double EventHorizon(double mass)
        {
            double g = 6.674 * Math.Pow(10, -11);
            int c = 299792458;
            double radius = (2 * g * mass) / Math.Pow(c, 2);
            return radius;
        }
    }
}
