using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigitIs7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            
            if ((a%1000)/100  == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }


            int b = 701;

            if ((b % 1000) / 100 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int c = 9703;

            if ((c % 1000) / 100 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int d = 877;

            if ((d % 1000) / 100 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int e = 777877;

            if ((e % 1000) / 100 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            int f = 9999799;

            if ((f % 1000) / 100 == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            
            }
    }
}
