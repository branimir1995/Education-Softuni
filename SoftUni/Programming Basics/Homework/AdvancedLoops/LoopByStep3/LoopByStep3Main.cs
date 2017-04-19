using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopByStep3
{
    public class LoopByStep3Main
    {
        public static void Main()
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i+=3)
            {
                Console.WriteLine(i);
            }




        }
    }
}
