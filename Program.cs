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
            Console.Write("Enter the number to be check: ");
            //VARIABLES
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            int j = 0;
            while (number > i)
            {
                j = number % i == 0 ? j + i : j;
                i++;
            }
            string result = j == number ? $"{number} is a perfect number" : $"{number} is not a perfect number";
            Console.WriteLine(result);
        }            
    }
}
