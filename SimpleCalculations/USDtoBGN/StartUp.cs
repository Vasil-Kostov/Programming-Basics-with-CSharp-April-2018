﻿using System;

namespace USDtoBGN
{
    class StartUp
    {
        static void Main()
        {
            var usd = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} BGN", Math.Round((usd * 1.79549), 2));
        }
    }
}
