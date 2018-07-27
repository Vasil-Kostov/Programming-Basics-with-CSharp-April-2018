using System;

namespace ТръбиВБасейн
{
    class StartUp
    {
        static void Main()
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var waterFlow = (p1 * h) + (p2 * h);

            if (waterFlow <= v)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", 
                    (int)((waterFlow / v) * 100),
                    (int)(((p1 * h) / waterFlow) * 100),
                    (int)(((p2 * h) / waterFlow) * 100));
                //Math.Round((waterFlow / v) * 100),
                //Math.Round(((p1 * h) / waterFlow) * 100),
                //Math.Round(((p2 * h) / waterFlow) * 100));
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1:F1} liters.",
                    h, waterFlow - v);
            }
        }
    }
}
