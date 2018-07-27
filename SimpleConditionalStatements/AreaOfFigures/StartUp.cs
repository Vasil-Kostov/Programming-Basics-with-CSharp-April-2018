using System;

namespace AreaOfFigures
{
    class StartUp
    {
        static void Main()
        {
            var figureTipe = Console.ReadLine();

            switch (figureTipe)
            {
                case "square":
                    var side = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round((side * side), 3));
                    break;
                case "rectangle":
                    var sideA = double.Parse(Console.ReadLine());
                    var SideB = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round((sideA * SideB), 3));
                    break;
                case "circle":
                    var r = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round((Math.PI * (r * r)), 3));
                    break;
                case "triangle":
                    var baseLength = double.Parse(Console.ReadLine());
                    var hight = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(((baseLength * hight) / 2d), 3));
                    break;
                default:
                    break;
            }
        }
    }
}
