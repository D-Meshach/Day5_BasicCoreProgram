using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class power2
    {
        public static void power_count()
        {

            Console.WriteLine("Enter the number of times to print power 2\n");
            int count = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= count) {
                Console.WriteLine("2^"+i+"="+Math.Pow(2, i));
                i++;
            }

        }
       
    }
}
