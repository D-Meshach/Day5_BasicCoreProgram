using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class factors
    {
        //Prime factorization method by using brute force method
        public static void factor_find() {

            Console.WriteLine("Enter the number greater than 1");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1)
            {

                Console.WriteLine("Enter number greater than 1");

            }
            else {
                int count = 0;
                Console.WriteLine("The Prime Factors are");
                for (int i = 1; i <=number; i++) 
                {

                    if (number % i == 0) {
                        int tempno = 0;
                        for (int j = 1; j <= i; j++) {
                            if (i % j == 0) {
                                tempno++;
                               
                            }
                        }
                        if (tempno <=2) {
                            Console.WriteLine(i);
                        }


                   }
                    

                }
               
            
            }
            


        }
    

    }
}
