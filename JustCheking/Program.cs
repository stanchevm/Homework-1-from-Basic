using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustCheking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    counter++;
                }
            }

            if (counter > 2)
            {
                Console.WriteLine(a + " is not prime");
            }
            else
            {
                Console.WriteLine(a + " is prime");
            }
        }

    }
}
