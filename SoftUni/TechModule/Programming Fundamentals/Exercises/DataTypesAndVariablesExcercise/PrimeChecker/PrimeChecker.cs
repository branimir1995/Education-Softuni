using System;


namespace PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 2; i <= input; i++)
            {
                bool isPrime = true;
                for (int delitel = 2; delitel <= Math.Sqrt(i); delitel++)
                {
                    if (i % delitel == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    

                }
                Console.WriteLine($"{i} -> {isPrime}");


            }



        }
    }
}
