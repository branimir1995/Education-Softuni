﻿using System;


namespace VowelToDigit
{
    public class VowelToDigit
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            switch (input)
                
            {
                case 'a':
                case 'o':
                case 'i':
                case 'e':
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("digit");
                    break;
                default:
                    Console.WriteLine("other");
                    break;
                
            }


        }
        }
    }
