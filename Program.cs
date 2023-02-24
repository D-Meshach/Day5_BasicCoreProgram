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
                Console.Write("Enter \n 1) for Flip coin ");
                var a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Enter the number of times to flip coin"); int cnt = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(cnt);
                        flip_coin fp = new flip_coin(cnt);
                        break;
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
