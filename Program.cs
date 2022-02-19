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
            //VARIABLES
            Console.Write("Enter the temperature value : ");
            double tempToBeCoverted =Convert.ToInt32(Console.ReadLine());
            TemperatureConversion T1 = new TemperatureConversion();
            T1.TempConversion(tempToBeCoverted);
        }
    }
    class TemperatureConversion
    {
        public void TempConversion(double x)
        {
            //VARIABLES
            int option;
            do
            {
                Console.WriteLine("Enter the option for Converting Temperature \n 1 :- For changing F to C \n 2 :- For changing C to F ");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        double celciusTemperature = (x - 32) * 5 / 9;
                        Console.WriteLine($"The Celcius temperatue is {celciusTemperature}");
                        break;
                    case 2:
                        double farenhiteTemperature = (x * 9 / 5) + 32;
                        Console.WriteLine($"The farenhite temperatue is {farenhiteTemperature}");
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;

                }
            } while (option != 1 && option != 2);

        }
    }
}
