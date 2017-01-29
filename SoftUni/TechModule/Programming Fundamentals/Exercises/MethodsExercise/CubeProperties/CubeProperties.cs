using System;


namespace CubeProperties
{
    public class CubeProperties
    {
        public static double Face(double side)
        {
            double face = Math.Sqrt(2 * side * side);
            return face;
        }

        public static double Area(double side)
        {
            double area = 6 * (side * side);
            return area;
        }

        public static double Space(double side)
        {
            double space = Math.Sqrt(2 * (side * side));
            return space;
        }

        public static double Volume(double side)
        {
            double volume = side * side * side;
            return volume;
        }

        public static void Main()
        {

            double side = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            if (type == "face")
            {
                //Face(side);
                Console.WriteLine("{0:f2}",Face(side));
            }
            else if (type == "area")
            {
                //Area(side);
                Console.WriteLine("{0:f2}", Area(side));
            }
            else if (type == "space")
            {
                //Space(side);
                Console.WriteLine("{0:f2}", Space(side));
            }
            else if (type == "volume")
            {
                //Volume(side);
                Console.WriteLine("{0:f2}", Volume(side));
            }



        }
    }
}
