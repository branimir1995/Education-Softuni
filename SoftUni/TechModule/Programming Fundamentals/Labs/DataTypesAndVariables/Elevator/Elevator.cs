using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());

            int courses = people / weight;

            if (people % weight == 0)
            {
                
            }
            else
            {
                courses += 1;
            }

            Console.WriteLine(courses);


        }
    }
}
