using System;

namespace TrapezoidArea
{
    class StartUp
    {
        static void Main()
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine("Trapezoid area = {0}", (b1 + b2) * h / 2);
        }
    }
}
