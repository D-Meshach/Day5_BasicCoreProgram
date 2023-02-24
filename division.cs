using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class division
    {

        //Finding the quotient and remainder
        public static void find_quot_rem_div() 
        {
            Console.WriteLine("Enter the first Number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            
            double num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 > num1)
            {
                Console.WriteLine("Enter Numerator Greater than denominator");
            }
            else {
                double rem = num1 % num2;
                Console.WriteLine("The quotient is " + ((int)(num1 / num2)));
                Console.WriteLine("The remainder is " + rem);
            }
            


        }

    }
}
