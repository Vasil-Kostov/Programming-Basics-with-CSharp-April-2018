using System;

namespace Cinema
{
    class StartUp
    {
        static void Main()
        {
            var type = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "premiere":
                    Console.WriteLine("{0:F2} leva", rows * columns * 12);
                    break;
                case "normal":
                    Console.WriteLine("{0:F2} leva", rows * columns * 7.5);
                    break;
                case "discount":
                    Console.WriteLine("{0:F2} leva", rows * columns * 5);
                    break;
                default:
                    break;
            }
        }
    }
}
