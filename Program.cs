using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            TemperatureConversion.CelciousToFarenhite(37.2);       
        }
        class TemperatureConversion
        {
            public static void CelciousToFarenhite(double x)
            {
                double farenhiteTemperature = (x * 9 / 5) + 32;
                Console.WriteLine($"The farenhite temperatue is {farenhiteTemperature}");
            }
            public static void farenhiteToCelcius(double x)
            {
                double celciusTemperature = (x - 32) * 9/5;
                Console.WriteLine($"The farenhite temperatue is {celciusTemperature}");
            }
        }
    }
}
