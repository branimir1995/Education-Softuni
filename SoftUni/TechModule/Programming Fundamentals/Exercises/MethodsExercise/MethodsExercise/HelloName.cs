using System;


namespace MethodsExercise
{
    public class HelloName
    {
        public static void WriteName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }



        public static void Main()
        {

            string name = Console.ReadLine();
            WriteName(name);
        }
    }
}
