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
            Console.Write("Enter decimal Number: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Binary b1 = new Binary(N);
            Console.WriteLine($"The number after swapping binary nibbles is {b1.swapNibbles()}");

        }
        public class Binary
        {
            public int x;

            public Binary(int X)
            {
                this.x = X;
            }
            public int swapNibbles()
            {
                return ((x & 0x0F) << 4 | (x & 0xF0) >> 4);
            }
        }
        
    }
}
