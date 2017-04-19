using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenSums
{
    public class OddAndEvenSumsMain
    {
        public static void Main()
        {

            int lines = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < lines; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }

            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes" +
                    $"Sum = {sumEven}");
            }
            else
            {
                if (sumEven > sumOdd)
                {
                    Console.WriteLine($"No" +
                        $"Diff = {sumEven - sumOdd}");
                }
                else if (sumOdd > sumEven)
                {
                    Console.WriteLine($"No" +
                        $"Diff = {sumOdd - sumEven}");
                }
            }
        }
    }
}
