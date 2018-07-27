using System;

namespace Rectangles
{
    class Startup
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            
            double perimeter = (width * 2D) + (hight * 2D);
            double area = width * hight;

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
        }
    }
}
