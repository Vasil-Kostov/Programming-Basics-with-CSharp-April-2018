﻿using System;

namespace NumberToText
{
    class StartUp
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            if (number < 10)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
