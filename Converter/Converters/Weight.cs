using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter.Converters
{
    public class Weight
    {
        /// <summary>
        /// Pound to g = x
        /// G to pound = /
        /// </summary>
        double poundToKg = 0.45359237;
        double poundToG = 453.59237;
        double poundToMg = 453562.37;
        
        /// <summary>
        /// Stone to g = x
        /// G to stone = /
        /// </summary>
        double stoneToKg = 6.350293;
        double stoneToG = 6350.293;
        double stoneToMg = 6350293;

        /// <summary>
        /// Ounce to g = x
        /// G to ounce = /
        /// </summary>
        double ounceToKg = 0.02834952;
        double ounceToG = 28.34952;
        double ounceToMg = 28349.52;

        /// <summary>
        /// Stone to pound = x
        /// Pound to stone = /
        /// </summary>
        double stoneToPound = 14;

        /// <summary>
        /// Pound to ounce = x
        /// Ounce to pound = /
        /// </summary>
        double poundToOunce = 16;

        /// <summary>
        /// Stone to ounce = x
        /// Ounce to stone = /
        /// </summary>
        double stoneToOunce = 224;
    }
}
