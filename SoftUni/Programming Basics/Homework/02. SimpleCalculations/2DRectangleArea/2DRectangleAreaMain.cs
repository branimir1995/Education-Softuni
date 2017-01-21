using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Abs(x1 - x2);
            double length = Math.Abs(y2 - y1);
            Console.WriteLine("Area = {0}", width * length);
            Console.WriteLine("Perimeter = {0}", (width + length) * 2);

        }
    }
}
