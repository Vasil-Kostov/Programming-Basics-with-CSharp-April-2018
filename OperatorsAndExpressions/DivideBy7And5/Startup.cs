﻿using System;

namespace DivideBy7And5
{
    class Startup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if (number % 7 == 0 && number % 5 == 0)
            {
                Console.WriteLine("true {0}", number);
            }
            else
            {
                Console.WriteLine("false {0}", number);
            }
        }
    }
}
