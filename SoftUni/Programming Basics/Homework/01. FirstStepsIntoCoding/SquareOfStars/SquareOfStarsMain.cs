using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class SquareOfStarsMain
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            Console.Clear();

            string stars = new string('*', a);
            Console.WriteLine(stars);

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(stars);

                

            }

        }
    }
}
