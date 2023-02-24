using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    public class swap
    {

        public static void swap_number() {

            int a, b,temp;
            Console.WriteLine("Enter the value of a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a=" + a + " and b=" + b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After Swapping a=" + a + " and b=" + b);


        }

    }
}
