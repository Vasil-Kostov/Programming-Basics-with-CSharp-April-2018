using System;

namespace WineNeeded
{
    class StartUp
    {
        static void Main()
        {
            var squareMetersOfVineyard = int.Parse(Console.ReadLine());
            var grapesPerSqareMeter = double.Parse(Console.ReadLine());
            var litresOfWineNeeded = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());

            var grapesForWine = 0.40 * (squareMetersOfVineyard * grapesPerSqareMeter);
            var wine = grapesForWine / 2.5;

            if (wine < litresOfWineNeeded)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",
                  Math.Floor(litresOfWineNeeded - wine));
            }
            else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",
                    Math.Ceiling(wine - litresOfWineNeeded),
                    Math.Ceiling((wine - litresOfWineNeeded) / workers));
            }
        }
    }
}
