using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSums
{
    public class ComparingTwoSumsMain
    {
        public static void Main()
        {

            int lines = int.Parse(Console.ReadLine());
            int sumOne = 0;
            int sumTwo = 0;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sumOne += num;
            }

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sumTwo += num;
            }

            if (sumOne == sumTwo)
            {
                Console.WriteLine($"Yes, sum = {sumOne}");
            }
            else if (sumOne != sumTwo)
            {
                if (sumOne > sumTwo)
                {
                    Console.WriteLine($"No, diff = {sumOne - sumTwo}");
                }
                else
                {
                    Console.WriteLine($"No, diff = {sumTwo - sumOne}");
                }
            }

        }
    }
}
