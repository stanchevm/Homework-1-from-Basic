using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBitFromInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int shiftedNumber = number >> int.Parse(Console.ReadLine());
            int mask = 1;
            Console.WriteLine("The bit is  {0}", Convert.ToString(shiftedNumber & mask, 2));
        }
    }
}
