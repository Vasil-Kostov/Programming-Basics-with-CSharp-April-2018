using System;

namespace BirthDay_DrinkCost_
{
    class StartUp
    {
        static void Main()
        {
            var whiskyPrice = double.Parse(Console.ReadLine());
            var beerAmount = double.Parse(Console.ReadLine());
            var wineAmount = double.Parse(Console.ReadLine());
            var rakiaAmount = double.Parse(Console.ReadLine());
            var whiskyAmount = double.Parse(Console.ReadLine());

            var rakiaPrice = whiskyPrice * 0.5;
            var winePrice = rakiaPrice * 0.6;
            var beerPrice = rakiaPrice * 0.2;
            Console.WriteLine("{0:F2}", (whiskyPrice* whiskyAmount) + (rakiaPrice * rakiaAmount) +
                (winePrice * wineAmount) + (beerPrice * beerAmount));
        }
    }
}
