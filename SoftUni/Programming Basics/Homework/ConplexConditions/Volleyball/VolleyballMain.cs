using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class VolleyballMain
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            var praznik = int.Parse(Console.ReadLine());
            var patuvane = int.Parse(Console.ReadLine());
            var weekend = 48;


            double games = weekend - patuvane;
            double gamesSofia = games * (3.0 / 4);
            double gamesPraznik = praznik * (2.0 / 3);
            double gamesTotal = gamesSofia + gamesPraznik + patuvane;

            if (year == "leap")
            {
                double gamesLeap = gamesTotal + (gamesTotal * 0.15);
                
                Console.WriteLine(Math.Truncate(gamesLeap));
            }
            else if (year == "normal")
            {
                
                Console.WriteLine(Math.Truncate(gamesTotal));
            }





        }
    }
}
