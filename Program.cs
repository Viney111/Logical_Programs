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
            MonthlyPayment(2000, 2, 3.2);
        }
        static void MonthlyPayment(int Principal, int Year, double Rate)
        {
            //VARIABLES
            int n = 12 * Year;
            double r = Rate / (12 * 100);

            double monthlyPayment = (Principal * r) / (1 - Math.Pow(1 + r, -n)) ;
            Console.WriteLine($"Monthly payment is {monthlyPayment}");
        }
    }
}
