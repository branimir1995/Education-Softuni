using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseLoop
{
    public class ReverseLoopMain
    {
        public static void Main()
        {

            int num = int.Parse(Console.ReadLine());

            for (int i = num; i > 0; i--)
            {
                Console.WriteLine(i);
            }



        }
    }
}
