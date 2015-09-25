using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 1; i <= a; i++)
            
                if (a % i == 0)
                {
                    counter++;
                }
                if (counter > 2)
                {
                    Console.WriteLine(false);
                }
                else
                {
                    Console.WriteLine(true);
                }
            
            }
    }
}
