using System;


namespace BooleanPractice
{
    public class BooleanPractice
    {
         public static void Main()
        {
            string input = Console.ReadLine();
            bool boolean = Convert.ToBoolean(input);

            if (input == "True")
            {
                Console.WriteLine("Yes");
            }
            else if (input == "False")
            {
                Console.WriteLine("No");
            }


        }
    }
}
