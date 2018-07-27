using System;

namespace _4.CatFood
{
    class StartUp
    {
        static void Main()
        {
            var cats = int.Parse(Console.ReadLine());
            var foodGrams = 0.0;
            var group1 = 0;
            var group2 = 0;
            var group3 = 0;

            for (int i = 0; i < cats; i++)
            {
                var catEats = double.Parse(Console.ReadLine());
                if (catEats >= 100 && catEats < 200)
                {
                    group1++;
                }
                else if (catEats >= 200 && catEats < 300)
                {
                    group2++;
                }
                else
                {
                    group3++;
                }
                foodGrams += catEats;
            }

            var foodCost = (foodGrams / 1000) * 12.45;

            Console.WriteLine("Group 1: {0} cats.", group1);
            Console.WriteLine("Group 2: {0} cats.", group2);
            Console.WriteLine("Group 3: {0} cats.", group3);
            Console.WriteLine("Price for food per day: {0} lv.", Math.Round(foodCost, 2));
        }
    }
}
