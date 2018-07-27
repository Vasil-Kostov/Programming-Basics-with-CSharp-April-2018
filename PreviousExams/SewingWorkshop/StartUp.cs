using System;

namespace SewingWorkshop
{
    class StartUp
    {
        static void Main()
        {
            var amount = int.Parse(Console.ReadLine());
            var lenght = double.Parse(Console.ReadLine());
            var widht = double.Parse(Console.ReadLine());
            int squarePrice = 9;
            int rectanglePrice = 7;
            double USDtoBGN = 1.85;

            double rectangeArea = ((lenght + 0.60) * (widht + 0.60)) * amount;
            double squareArea = ((lenght / 2) * (lenght / 2)) * amount;

            Console.WriteLine("{0:F2} USD", (rectangeArea * rectanglePrice) + (squareArea * squarePrice));
            Console.WriteLine("{0:F2} BGN",
                USDtoBGN * ((rectangeArea * rectanglePrice) + (squareArea * squarePrice)));
        }
    }
}
