using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 4;
            int area = a * b;
            int perimeter = 2 * (a + b);
            Console.WriteLine("The area of a rectangle is = {0}", area);
            Console.WriteLine("the perimeter of a rectangle is = {0}", perimeter);

            double c = 2.5;
            double d = 3;
            double areaOfRectangle2 = c * d;
            double perimeterOfRectangle2 = 2 * (c + d);
            Console.WriteLine("The area of a rectangle is = {0}", areaOfRectangle2);
            Console.WriteLine("the perimeter of a rectangle is = {0}", perimeterOfRectangle2);

            int e = 5;
            int f = 5;
            int areaOfRectangle3 = e * f;
            int perimeterOfRectangle3 = 2 * (e + f);
            Console.WriteLine("The area of a rectangle is = {0}", areaOfRectangle3);
            Console.WriteLine("the perimeter of a rectangle is = {0}", perimeterOfRectangle3);
        }
    }
}
