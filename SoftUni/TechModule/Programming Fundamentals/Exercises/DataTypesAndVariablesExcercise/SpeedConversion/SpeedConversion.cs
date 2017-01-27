using System;


namespace SpeedConversion
{
    public class SpeedConversion
    {
        public static void Main()
        {

            uint distanceInMeters = UInt32.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minuts = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            int allSeconds = (int)((hours * 3600) +(minuts * 60) +seconds);
            float metersPerSec = (float)distanceInMeters / (float)allSeconds;
            float kilometersPerHour = ((float)distanceInMeters / 1000) / ((float)allSeconds / 3600);
            float milesPerHour = ((float)distanceInMeters / 1609) / ((float)allSeconds / 3600);

            Console.WriteLine("{0:0.#######}", metersPerSec);
            Console.WriteLine("{0:0.#######}", kilometersPerHour);
            Console.WriteLine("{0:0.#######}", milesPerHour);

        }
    }
}
