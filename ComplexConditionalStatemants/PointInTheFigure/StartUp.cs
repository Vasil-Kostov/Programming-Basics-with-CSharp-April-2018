using System;

namespace PointInTheFigure
{
    class StartUp
    {
        static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if (((x > 0 && x < 3 * h) && (y > 0 && y < h)) 
                || ((x > h && x < 2* h) && (y >= h && y < 4 * h)))
            {
                Console.WriteLine("inside");
            }
            else if ((y == 0 && x >= 0 && x <= 3 * h) || (y == h && x >= 0 && x <= h) 
                || (y == h && x >= 2 *h && x <= 3 * h) || (x == h && y > h && y < 4 * h) 
                || (x == 2 * h && y > h && y < 4 * h) || (y == 4 * h && x >= h && x <= 2 * h)
                || (x == 0 && y > 0 && y < h) || (x == 3 * h && y > 0 && y < h))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
