using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SimpleConditions
{
    class TimePlus15Main
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            m = m + 15;

            if (m < 10)
            {
                Console.WriteLine(h + ":0" + m);
            }
            else if (m >= 60)
            {
                h = h + 1;
                m = m - 60;
                if (h > 24 && m >= 1 && m <= 9)
                {
                    h = h - 24;
                    Console.WriteLine("{0}:0{1}", h, m);
                }
                else if (h >= 24 && m >= 10)
                {
                    h = h - 24;
                    Console.WriteLine("{0}:{1}", h, m);
                }
                else if (h == 24 && m == 0)
                {
                    Console.WriteLine("0:00");
                }
                else if (h == 24 && m >= 1 && m <= 9)
                {

                    Console.WriteLine("0:0{0}", m);
                }
                else if (h == 24 && m >= 10)
                {

                    Console.WriteLine("0:{0}", m);
                }
                else
                {
                    if (m >= 0 && m <= 9)
                    {
                        Console.WriteLine(h + ":0" + m);
                    }
                    else
                    {
                        Console.WriteLine(h + ":" + m);
                    }
                }

            }
            else if (h > 23)
            {
                h = h % 24;
                Console.WriteLine("{0}:{01:00}", h, m);
            }
            else
            {
                Console.WriteLine("{0}:{1}", h, m);
            }

        }
    }
}
