using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class InvalidNumberMain
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            if (!(a >= 100 && a <= 200 || a == 0))
            {
                Console.WriteLine("invalid");
            }
            else
            {
                Console.WriteLine();
            }



        }
    }
}
