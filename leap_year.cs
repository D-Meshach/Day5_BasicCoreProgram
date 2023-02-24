using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class leap_year
    {
        //int a =Convert.ToInt32( Console.ReadLine());
        public leap_year() {
            //local Variables
            int year = 0;
            int div_checkby_4 =0;
            int div_checkby_100 = 0;
            int div_checkby_400 = 0;
            Console.WriteLine("Enter the year greater than 1000 and less than 9999");
            year =Convert.ToInt32( Console.ReadLine());
            //leap year calculation
            if (year > 1000 && year < 9999)
            {
                div_checkby_4 = year % 4;
                div_checkby_100 = year % 100;
                div_checkby_400 = year % 400;

                if (div_checkby_4 == 0)
                {

                    if ((div_checkby_100 != 0) || (div_checkby_100 == 0 && div_checkby_400 == 0))
                    {

                        Console.WriteLine("Its a leap Year");

                    }
                    else
                    {
                        Console.WriteLine("Its Not a leap Year");

                    }

                }
                else
                {
                    Console.WriteLine("Its not a leap year");
                }


            }
            else {

                Console.WriteLine("ENter valid 4 digit year");
            }


        }
        
    }
}
