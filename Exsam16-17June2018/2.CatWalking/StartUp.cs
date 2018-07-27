using System;

namespace _2.CatWalking
{
    class StartUp
    {
        static void Main()
        {
            var minutesPerWalk = int.Parse(Console.ReadLine());
            var amountOfWalks = int.Parse(Console.ReadLine());
            var calsPerDay = int.Parse(Console.ReadLine());

            var allWalksTime = minutesPerWalk * amountOfWalks;
            var burnedCals = allWalksTime * 5;
            if (burnedCals >= calsPerDay / 2)
            {
                Console.WriteLine("Yes, the walk for your cat is enough. Burned calories per day: {0}.", burnedCals);
            }
            else
            {
                Console.WriteLine("No, the walk for your cat is not enough. Burned calories per day: {0}.", burnedCals);
            }
        }
    }
}
