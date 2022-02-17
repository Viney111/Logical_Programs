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
            Console.WriteLine(sqrt(563));
        }
        static double sqrt(double C)
        {
            double t = C;
            while (Math.Abs(t - (C / t)) > 1e-15 * t)
            {
                t = (t + (C / t)) / 2;

            }
            return t;
        }
    }
}
