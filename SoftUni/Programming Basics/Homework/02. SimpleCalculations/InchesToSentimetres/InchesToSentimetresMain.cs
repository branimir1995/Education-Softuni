using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToSentimetres
{
    class InchesToSentimetresMain
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            var inches = double.Parse(Console.ReadLine());
            var sentimetres = inches * 2.54;
            Console.Write("Sentimetres = ");
            Console.WriteLine(sentimetres);

        }
    }
}
