using System;

namespace CelsiouToFahrenheit
{
    class StartUp
    {
        static void Main()
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine(fahrenheit);
        }
    }
}
