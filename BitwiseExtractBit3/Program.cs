using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseExtractBit3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            //int shiftedNumber = number >> 3;
            //int mask = 1;
            //Console.WriteLine("bit #3 is {0}", Convert.ToString(shiftedNumber & mask,2) );

            int n = 5;

            bool divided = (n % 7 == 0 && n % 5 == 0 && n != 0);
            Console.WriteLine(divided);

        }
    }
}
