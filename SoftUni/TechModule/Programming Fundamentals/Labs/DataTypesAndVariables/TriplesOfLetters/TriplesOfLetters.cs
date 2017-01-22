using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    for (int thirdletter = 0; thirdletter < num; thirdletter++)
                    {
                        char letterOne = (char)('a' + i);
                        char letterTwo = (char)('a' + j);
                        char letterThree = (char)('a' + thirdletter);

                        Console.WriteLine($"{letterOne}{letterTwo}{letterThree}");
                    }
                   
                }
               
            }


        }
    }
}
