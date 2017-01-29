using System;
using System.Numerics;

namespace Factoriel
{
    class Factoriel
    {

        public static BigInteger Factor(int num)
        {
            BigInteger fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }

            return fact;
        }


        static void Main()
        {

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(Factor(num));

        }
    }
}
