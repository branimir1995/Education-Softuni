using System;


namespace PrintAsciiTable
{
    public class AsciiTable
    {
        public static void Main()
        {
            int startingNumber = int.Parse(Console.ReadLine());
            int finalNumber = int.Parse(Console.ReadLine());

            for (int i = startingNumber; i <= finalNumber; i++)
            {
                char output = Convert.ToChar(i);
                Console.Write(output + " ");
                

            }



        }
    }
}
