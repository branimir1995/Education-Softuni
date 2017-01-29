using System;


namespace MaxMethod
{
    class MaxMethod
    {
        public static void Max(int a, int b, int c)
        {
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else if (c >= a && c >= b)
            {
                Console.WriteLine(c);
            }



        }



        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Max(a, b, c);



        }
    }
}