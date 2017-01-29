using System;



public class Program
{
    public static void Main()
    {

        long num = long.Parse(Console.ReadLine());
        bool isPrime = true;

        if (num == 0 || num == 1)
        {
            isPrime = false;
        }

        for (int checker = 2; checker <= Math.Sqrt(num); checker++)
        {
            if (num != checker && num % checker == 0)
            {
                isPrime = false;
            }
            else if (num == checker && num % checker == 0 && checker % 2 != 0)
            {
                isPrime = true;
            }
        }


        Console.WriteLine(isPrime);

    }
}

