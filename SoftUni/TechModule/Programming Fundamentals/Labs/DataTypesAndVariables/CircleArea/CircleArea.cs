﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class CircleArea
    {
        static void Main(string[] args)
        {

            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:f12}", Math.PI * radius * radius);



        }
    }
}
