using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInsideACircleAndOutsideOfARectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if ((x >= 0.5 && x <= 2.5) && (y >= 0.5 && y <= 2.5))
            {
            Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            }
    }
}
