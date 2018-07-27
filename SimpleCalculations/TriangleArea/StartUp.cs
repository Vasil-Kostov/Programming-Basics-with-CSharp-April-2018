using System;

namespace TriangleArea
{
    class StartUp
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle area = {0}", Math.Round((a * h / 2), 2));
        }
    }
}
