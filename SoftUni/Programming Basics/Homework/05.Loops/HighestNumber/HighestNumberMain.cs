using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestNumber
{
    public class HighestNumberMain
    {
        public static void Main()
        {

            int lines = int.Parse(Console.ReadLine());
            int max = 0;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine(max);
        }
    }
}
