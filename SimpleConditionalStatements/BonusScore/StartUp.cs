﻿using System;

namespace BonusScore
{
    class StartUp
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            double bonusScore = 0;

            if (number <= 100)
            {
                bonusScore = 5;
            }
            else if (number > 100 & number <= 1000)
            {
                bonusScore = number * 0.2;
            }
            else
            {
                bonusScore = number * 0.1;
            }

            if (number % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (number % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(number + bonusScore);
        }
    }
}
