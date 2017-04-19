using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOtherElements
{
    public class SumOfOtherElementsMain
    {
        public static void Main()
        {

            int lines = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                    
                }

                if (num <= max)
                {
                    sum += num;
                }

            }

           

            if (sum == max)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else if (sum != max)
            {
                if (sum > max)
                {
                    Console.WriteLine($"No, diff = {sum - max}");
                }
                else if (sum < max)
                {
                    Console.WriteLine($"No, diff = {max - sum}");
                }
            }

        }
    }
}
