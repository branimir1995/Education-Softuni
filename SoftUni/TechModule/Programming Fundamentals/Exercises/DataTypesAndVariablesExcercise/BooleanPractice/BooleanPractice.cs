using System;


namespace BooleanPractice
{
    public class BooleanPractice
    {
         public static void Main()
        {
            string input = Console.ReadLine();
            bool boolean = Convert.ToBoolean(input);

            if (boolean == true)
            {
                Console.WriteLine("Yes");
            }
            else if (boolean == false)
            {
                Console.WriteLine("No");
            }


        }
    }
}
