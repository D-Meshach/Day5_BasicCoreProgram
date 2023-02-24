using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = "y";
            while (i == "y")
            {
                Console.Write("Enter \n 1) for Flip coin  \n 2)for leap year \n 3) power of 2 \n 4) Harmonic Number \n 5) for factors \n 6)Find quotient and remainder    \n Enter Option \n\n");
                var a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Enter the number of times to flip coin"); int cnt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cnt);
                        flip_coin fp = new flip_coin(cnt);
                        break;
                    case 2: leap_year lp = new leap_year(); break;
                    case 3: power2.power_count(); break;
                    case 4: harmonic.harmonic_num(); break;
                    case 5: factors.factor_find(); break;
                    case 6: division.find_quot_rem_div(); break;
                    default: Console.WriteLine("Invalid Option");
                        break;


                }
                Console.WriteLine("Do you wish to continue (y/n)?");
                i = Console.ReadLine();

                if (i == "n")
                {
                    break;
                }
            }
        }
    }
}
