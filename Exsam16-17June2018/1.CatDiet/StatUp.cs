using System;

namespace _1.CatDiet
{
    class StatUp
    {
        static void Main()
        {
            var fatP = int.Parse(Console.ReadLine());
            var proteinP = int.Parse(Console.ReadLine());
            var carbsP = int.Parse(Console.ReadLine());
            var kcalls = int.Parse(Console.ReadLine());
            var waterP = int.Parse(Console.ReadLine());

            var foodWeigth = (((fatP / 100.0) * kcalls / 9)) + (((proteinP / 100.0) * kcalls / 4)) +
                (((carbsP / 100.0) * kcalls / 4));
            var kcallsPerGram = kcalls / foodWeigth;
            kcallsPerGram = kcallsPerGram * (1 - (waterP / 100.0));

            Console.WriteLine("{0:F4}", kcallsPerGram);
        }
    }
}
