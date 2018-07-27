using System;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            float w = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:F3}", (w*0.17f));
        }
    }
}
