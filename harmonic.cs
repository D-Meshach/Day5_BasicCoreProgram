using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class harmonic
    {
        public static void harmonic_num() {
            Console.Write("Enter the n number of harmonic value");
            int counts = Convert.ToInt32(Console.ReadLine());
            float total = 0;
            for (int i = 1; i <=counts; i++)
            {
                total += (1 /(float) i);
                Console.WriteLine("1/" + i + "=" + total);
            }
            Console.WriteLine("\n The nth Harmonic value =" + total);

        }
        
    }
}
