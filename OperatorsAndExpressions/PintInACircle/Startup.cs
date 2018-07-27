using System;

namespace PintInACircle
{
    class Startup
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2;
            double circleCenterX = 0;
            double circleCenterY = 0;

            bool isInside = 
                ((x - circleCenterX) *(x - circleCenterX))
                + ((y - circleCenterY) * (y - circleCenterY)) <= r*r;

            double pointDistance = Math.Abs(Math.Sqrt((x * x) + (y * y)));

            if (isInside)
            {
                Console.WriteLine("yes {0:F2}", pointDistance);
            }
            else
            {
                Console.WriteLine("no {0:F2}", pointDistance);
            }
        }
    }
}
