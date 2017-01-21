using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaFigures
{
    class Program
    {
        static void Main(string[] args)
        {

            string inputParam = Console.ReadLine();
            if (inputParam == "square")
            {
                var a = double.Parse(Console.ReadLine());
                var squareArea = a * a;
                Console.WriteLine(squareArea);
            }
            else if (inputParam == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                var recArea = a * b;
                Console.WriteLine(recArea);
            }
            else if (inputParam == "circle")
            {
                var a = double.Parse(Console.ReadLine());
                var circArea = Math.PI * a * a;
                Console.WriteLine(circArea);
            }
            else if (inputParam == "triangle")
            {
                var a = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var triangleArea = (a * h) / 2;
                Console.WriteLine(triangleArea);
            }

        }
    }
}
