using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenDegreesOfTwo
{
    public class EvenDegreesOfTwoMain
    {
        public static void Main()
        {
        
            int num = int.Parse(Console.ReadLine());
            int n = 1;
            Console.WriteLine(n);

            for (int i = 1; i <= num; i++)
            {
                
                    Console.WriteLine(n * (i * 4));
                
            }


        }
    }
}
