using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welocome to Logical Programs");
            Console.Write("Enter the number to be reversed: ");
            //VARIABLES
            int number = Convert.ToInt32(Console.ReadLine());
            int reverseNumber = 0;

            while(number > 0)
            {
                int rem = number % 10;
                reverseNumber = reverseNumber * 10 + rem;
                number /= 10;
            }
            Console.WriteLine($"The number after reversing is {reverseNumber}");
        }            
    }
}
