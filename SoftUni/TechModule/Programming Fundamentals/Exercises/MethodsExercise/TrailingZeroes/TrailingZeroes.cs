using System;
using System.Numerics;

namespace TrailingZeroes
{
    public class Program
    {
        public static BigInteger Factor(int num)
        {
            BigInteger fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            
            return Trail(fact);
        }

        public static BigInteger Trail(BigInteger fact)
        {
            BigInteger count = 0;
            BigInteger checker = fact;

            while (checker % 10 == 0)
            {
                count++;
                checker = checker / 10;
            }

            return count;
        }


        static void Main()
        {

            int num = int.Parse(Console.ReadLine());

          

            /*if (count == 1)
            {
                Console.WriteLine($"{num}! = {fact} -> One trailing zero");
            }
            else if (count > 1)
            {
                Console.WriteLine($"{num}! = {fact} -> {count} trailing zeroes");
            }*/

            Console.WriteLine(Factor(num));

        }
    }
}
