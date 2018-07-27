using System;

namespace DanceHall
{
    class StartUp
    {
        static void Main()
        {
            var L = double.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var A = double.Parse(Console.ReadLine());

            var AArea = A * A;
            var benchArea = (L * W) / 10;
            var restOfTheArea = (L * W) - (AArea + benchArea);
            Console.WriteLine((Convert.ToInt32(restOfTheArea*10000) / 7040));
        }
    }
}
