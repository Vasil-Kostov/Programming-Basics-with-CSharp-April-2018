using System;

namespace PointCircleRectangle
{
    class Starup
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double r = 1.5;
            double circleCenterX = 1;
            double circleCenterY = 1;

            bool isInsideCircle =
                ((x - circleCenterX) * (x - circleCenterX))
                + ((y - circleCenterY) * (y - circleCenterY)) <= r * r;

            bool isInsideRectange = ((y >= -1) && (y <= 1)) && ((x>=-1) && (x <= 5));


            if (isInsideCircle)
            {
                Console.Write("inside circle");
            }
            else
            {
                Console.Write("outside circle");
            }
            if (isInsideRectange)
            {
                Console.WriteLine(" inside rectangle");
            }
            else
            {
                Console.WriteLine(" outside rectangle");
            }

        }
    }
}
