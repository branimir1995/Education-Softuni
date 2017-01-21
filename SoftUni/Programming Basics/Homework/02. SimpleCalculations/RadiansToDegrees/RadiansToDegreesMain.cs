using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class RadiansToDegreesMain
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var degree = rad * 180 / Math.PI;
            Math.Round(degree, 2);
            Console.WriteLine(degree);
        }
    }
}
