using System;
using System.Numerics;

namespace DataTypesAndVariables
{
    public class CenturiesToMinutes
    {
        public static void Main()
        {

            int centuries = int.Parse(Console.ReadLine());
            int years = 100 * centuries;
            int days = (int)(years * 365.2422);
            long hours = days * 24;
            BigInteger minutes = hours * 60;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = seconds * 1000;
            BigInteger microsecond = seconds * 1000000;
            BigInteger nanoSeconds = seconds * 1000000000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microsecond} microseconds = {nanoSeconds} nanoseconds");



        }
    }
}
