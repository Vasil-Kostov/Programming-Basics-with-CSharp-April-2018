using System;

namespace RadiansToDegrees
{
    class StartUp
    {
        static void Main()
        {
            var radians = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round((radians*180/Math.PI), 2));
        }
    }
}
