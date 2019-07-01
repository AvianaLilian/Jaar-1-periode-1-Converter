using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Converters
{
    public class Temperature
    {
        /// <summary>
        /// Celcius to kelvin = x
        /// Kelvin to celcius = /
        /// </summary>
        double celsiusToKelvin = 274.15;

        /// <summary>
        /// Fahrenheit to kelvin = x
        /// Kelvin to fahrenheit = /
        /// </summary>
        double fahrenheitToKelvin = 255.92777778;

        /// <summary>
        /// Celcius to fahrenheit = x
        /// Fahrenheit to celcius = /
        /// </summary>
        double celciusTofahrenheit = (... * 1.8) + 32;
    }
}
