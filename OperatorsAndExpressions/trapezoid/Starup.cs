using System;

namespace Trapezoid
{
    class Starup
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("{0:F7}", ((a+b)/2)*h);
        }
    }
}
