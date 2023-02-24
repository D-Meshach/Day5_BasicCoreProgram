using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class large_among_3
    {
        public static void largest_num() {

            int[] num = new int[3];
           
            
          
           
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Enter "+i+" number ");
                num[i]= Convert.ToInt32(Console.ReadLine());
                

            }
            int gt = num[0];
            for (int i = 0; i < 3; i++)
            {
                if (gt < num[i])
                {
                    gt = num[i];
                }


            }

            Console.WriteLine("Greater among all is " + gt);

            

        }
      
    }
}
