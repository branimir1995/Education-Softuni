using System;


namespace RectangleProperties
{
    public class RectangleProperties
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            var perimeter = 2 * a + 2 * b;
            var area = a * b;
            var diagonal = (a * a) + (b * b);

            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.WriteLine(Math.Sqrt(diagonal));
        }

    }
}
