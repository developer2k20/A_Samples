using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoledemo
{
    class Program
    {
        static void Main(string[] args) {
            // Preferred syntax. Note that you cannot use var here instead of string[].
            string[] vowels1 = { "a", "e", "i", "o", "u" };


            // If you use explicit instantiation, you can use var.
            var vowels2 = new string[] { "a", "e", "i", "o", "u" };

            // If you specify an array size, you must initialize the elements one at a time.
            var vowels3 = new string[5];
            vowels3[0] = "a";
            vowels3[1] = "e";
            // And so on.

            int a=2;
            int b=4;

            int c = a + b;

            string s;
            s = "abc";
            Console.WriteLine("S = {0}",s);

            foreach(string item in vowels1)
            {
                Console.WriteLine("vowels3 Array element [{0}]", item.ToString());
            }



            Console.ReadKey();
        }
    }
}
