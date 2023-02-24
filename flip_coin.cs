using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    public class flip_coin
    {
        //flip coin 
        public flip_coin(int a) {
            int i = 0,head=0,tail=0;
            Random random = new Random();
            while (i < a) {
               int rand_number= random.Next(0,2);
                
                
                if (rand_number == 1)
                {
                    head += 1;
                }
                else {
                    tail += 1;
                }
                i++;
                
            }
            double P = (double)(100 / (double)a);
            double head_percent =(double) P * head;
            head_percent = Math.Round(head_percent, 1);
            double tail_percent =(double) P * tail;
            tail_percent = Math.Round(tail_percent, 1);
            Console.WriteLine("Head=" + head + "Tail=" + tail);
            Console.WriteLine("Head Percentage =" +(double) head_percent + "Tail Percentage=" + tail_percent);
        }

    }
}
