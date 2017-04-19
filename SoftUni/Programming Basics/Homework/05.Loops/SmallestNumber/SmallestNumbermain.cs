using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestNumber
{
    public class SmallestNumberMain
    {
        public static void Main()
        {

            int lines = int.Parse(Console.ReadLine());
            int min = int.MaxValue;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < min)
                {
                    min = num;
                }
            }

            Console.WriteLine(min);
        }
    }
}
