﻿using System;

namespace PowersOfTwo
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
