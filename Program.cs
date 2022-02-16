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
            //Taking Coupon Number Inputs from the User
            int[] couponNumbers = new int[4];
            for (int i = 0; i < couponNumbers.Length; i++)
            {
                Console.WriteLine("Enter the 3 digit coupon number: ");
                couponNumbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            //VARIABLES
            int totalRandomNumbers = 0;
            int j = 0;

            //Calculating the no. of times Rnadom function called to match all distinct coupoun numbers.
            while (j < 4)
            {
                if (couponNumbers[j] == GetRandomNumber())
                {
                    j++;
                }
                totalRandomNumbers++;
            }
            Console.WriteLine($"The no. of random function counters to match all coupon numbers is {totalRandomNumbers}");
        }
        //Function to get random number
        static int GetRandomNumber()
            {
                Random random = new Random();
                int r1 = random.Next(100, 1000);
                return r1;
            }
        
    }
}
