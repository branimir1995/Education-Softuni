using System;


namespace HexadecimalConversion
{
    public class HexaConvert
    {
        public static void Main()
        {
            string hexa = Console.ReadLine();
            var num = Convert.ToInt32(hexa, 16);
             

            Console.WriteLine(num);



        }
    }
}
