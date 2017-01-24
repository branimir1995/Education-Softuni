using System;


namespace DataTypesAndVariables
{
    public class CenturiesToMinutes
    {
        public static void Main()
        {

            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            long seconds = minutes * 60;
            long nanoSeconds = seconds * 1000000000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds");


        }
    }
}
