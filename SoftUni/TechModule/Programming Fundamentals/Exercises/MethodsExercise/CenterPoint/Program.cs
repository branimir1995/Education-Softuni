using System;
namespace _08.CenterPoint
{
    class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            CheckAndPrintDistance(x1, y1, x2, y2);
        }

        public static double Distance(double x, double y)
        {
            double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return distance;
        }

        public static void CheckAndPrintDistance
        (double x1, double y1, double x2, double y2)

        {
            double distancePoint1 = Distance(x1, y1);
            double distancePoint2 = Distance(x2, y2);

            double lengthPoint12 = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            if (distancePoint1 <= distancePoint2)
                Console.WriteLine($"({x1}, {y1})");
            else Console.WriteLine($"({x2}, {y2})");
        }
    }
}
