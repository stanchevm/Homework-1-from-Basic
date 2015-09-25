using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyABitAtGivenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int p = N >> int.Parse(Console.ReadLine());
            int v = int.Parse(Console.ReadLine());
           

            if (v == 0)
            {
                int mask = ~(1 << p);
                int result = N & mask;                 
                    Console.WriteLine(result);
            }
            if (v == 1)
            {
                int mask2 = 1 << p;
                int result2 = mask2 | N;
                Console.WriteLine(result2);
            }
        
        
        }
    }
}
