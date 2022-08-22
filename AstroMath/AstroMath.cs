using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    /// <summary>
    /// A library that performs calculation services for astronomical data.
    /// </summary>
    public class AstroMath
    {
        /// <summary>
        /// Calculates the star velocity for the given wavelengths, using the Doppler shift.
        /// </summary>
        /// <param name="observedWavelength">The observed wavelength of a star.</param>
        /// <param name="restWavelength">The rest wavelength of a star.</param>
        /// <returns>A double representing the velocity.</returns>
        public double StarVelocity(double observedWavelength, double restWavelength)
        {
            double delta = observedWavelength - restWavelength;
            double velocity = 2999792458 * (delta / restWavelength);
            return velocity;
        }
        /// <summary>
        /// Calculates the star distance, using the parallax angle.
        /// </summary>
        /// <param name="parallaxAngle">The parallax angle, in arcseconds.</param>
        /// <returns>A double, representing the distance in parsecs.</returns>
        public double StarDistance(double parallaxAngle)
        {
            double distance = 1 / parallaxAngle;
            return distance;
        }
        /// <summary>
        /// Converts a temperature from Celsius to Kelvin.
        /// </summary>
        /// <param name="celsius">The temperature, in degrees Celsius.</param>
        /// <returns>The temperature, in Kelvin.</returns>
        public double TempInKelvin(double celsius)
        {
            double kelvin = celsius + 273;
            return kelvin;
        }
        /// <summary>
        /// Calculates the distance from the centre of a black hole to the event horizon.
        /// </summary>
        /// <param name="mass">The mass of the black hole, in kilograms.</param>
        /// <returns>The event horizon, in metres.</returns>
        public double EventHorizon(double mass)
        {
            double g = 6.674 * Math.Pow(10, -11);
            int c = 299792458;
            double radius = (2 * g * mass) / Math.Pow(c, 2);
            return radius;
        }
    }
}
