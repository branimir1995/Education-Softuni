using System;


namespace ToHexAndBinary
{
    public class ToHexAndBinary
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            string hexa = Convert.ToString(input, 16).ToUpper();
            string binary = Convert.ToString(input, 2);

            Console.WriteLine(hexa);
            Console.WriteLine(binary);

        }
    }
}
