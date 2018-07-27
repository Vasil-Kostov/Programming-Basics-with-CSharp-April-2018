using System;

namespace IchesToCentimeters
{
    class StartUp
    {
        static void Main()
        {
            Console.Write("inches = ");
            double inches = double.Parse(Console.ReadLine());
            Console.Write("sentimeters = ");
            Console.WriteLine(inches * 2.54);
        }
    }
}
