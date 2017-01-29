using System;


namespace ReverseNumber
{
    public class ReverseNumber
    {

        public static void Reverse(int num)
        {
            int result = 0;
            while (num > 0)
            {
                result = result * 10 + num % 10;
                num /= 10;
            }
            Console.WriteLine(result);



        }

        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            Reverse(a);



        }
    }
}
