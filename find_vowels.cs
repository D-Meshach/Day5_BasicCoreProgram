using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace basic_core_day5
{
    internal class find_vowels
    {
        public static void find_vowel()
        {

            String[] ar = new String[] { "a", "e", "i", "o", "u" };
            Console.WriteLine("Enter an Alphabets");
            String alph = Convert.ToString(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < ar.Length; i++)
            {

                if (ar[i] == alph)
                {
                    count = 1;
                }


            }
            if (count == 1)
            {
                Console.WriteLine("It is Vowel");
            }
            else
            {
                Console.WriteLine("It is Consonent");
            }

            

        }
    }
}
