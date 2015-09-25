using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeziods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please put two numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine()) ;
            double h = double.Parse(Console.ReadLine());
            double half = (1.0/2.0);
            double area = (half) * (a + b) * h;
            Console.WriteLine(area);
        }
    }
}
