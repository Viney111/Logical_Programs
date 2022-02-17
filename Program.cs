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
            Console.WriteLine(ToBinary(198));
        }
        static string ToBinary(int N)
        {
            string binary = "";
            while (N > 0)
            {
                binary = N % 2 == 0 ? 0 + binary : 1 + binary;
                N /= 2;
            }
            return binary;
        }
        
    }
}
