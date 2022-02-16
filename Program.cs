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
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Enter START to start stopwatch: ");
            string s1 = Console.ReadLine().ToUpper();
            if (s1 == "START")
            {
                stopwatch.Start();
                Console.WriteLine("Enter END to stop stopwatch: ");
                string s2 = Console.ReadLine().ToUpper();
                if(s2 == "END")
                {
                    stopwatch.Stop();
                }
            }
            Console.WriteLine($"Time elpased is {stopwatch.ElapsedMilliseconds}");

        }        
    }
}
