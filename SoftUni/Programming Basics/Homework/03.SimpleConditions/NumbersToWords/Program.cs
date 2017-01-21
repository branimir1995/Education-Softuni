using System;

class NumberAsWords
{
    static void Main()
    {
        string[] onesWords = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] tensWords = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string hundred = "hundred";
        int n = int.Parse(Console.ReadLine());

        int hundreds = (n / 100) % 10;
        int tens = (n / 10) % 10;
        int ones = n % 10;

        if (hundreds > 0)
        {
            if (hundreds == 1)
            {
                Console.Write("A {0} ", hundred);
            }

            else
            {
                Console.Write("{0} {1} ", onesWords[hundreds], hundred);
            }

            if (tens > 0)
            {
                if (tens == 1)
                {
                    Console.Write("and {0} ", onesWords[ones + 10]);
                    return;
                }
                else
                {
                    Console.Write("and {0} ", tensWords[tens - 2]);
                }
                if (ones > 0)
                {
                    Console.Write("{0}", onesWords[ones]);
                }

                Console.WriteLine();
                return;
            }

            if (ones > 0)
            {
                Console.Write("and {0}", onesWords[ones]);
            }

            Console.WriteLine();
            return;
        }

        if (tens > 0)
        {
            if (tens == 1)
            {
                Console.Write("{0} ", onesWords[ones + 10]);
            }
            else
            {
                Console.Write("{0} ", tensWords[tens - 2]);
            }

            Console.WriteLine();
            return;
        }

        if (ones > 0)
        {
            Console.Write("{0}", onesWords[ones]);
        }

        else
        {
            Console.Write("{0}", onesWords[0]);
        }
        Console.WriteLine();
    }
}
