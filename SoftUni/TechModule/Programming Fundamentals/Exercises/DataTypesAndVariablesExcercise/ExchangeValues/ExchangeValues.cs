using System;


namespace ExchangeValues
{
    public class ExchangeValues
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(@"Before:
a = {0}
b = {1}", a, b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine(@"After:
a = {0}
b = {1}", a, b);

            //The code here looks ugly, I know.
            //I am using what I learned today.

        }
    }
}
