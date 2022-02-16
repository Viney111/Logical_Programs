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
            if (number > 1)
            {
                if (number != 2)
                {
                    int i = 2;
                    int flag = 0;
                    while (number > i)
                    {
                        if (number % i == 0)
                        {
                            Console.WriteLine($"{number} is not a prime number");
                            flag = 0;
                            break;
                        }
                        else
                        {
                            flag = 1;
                        }
                        i++;
                    }
                    string result = flag == 1 ? $"{number} is prime number" : "";
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine($"{number} is prime number");
                }
            }
            else
            {
                Console.WriteLine("Please enter a positive number");
            }

        }            
    }
}
