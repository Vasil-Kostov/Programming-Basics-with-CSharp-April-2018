using System;

namespace CharityCamaping
{
    class StartUp
    {
        static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var cooks = int.Parse(Console.ReadLine());
            var cakes = int.Parse(Console.ReadLine());
            var wafers = int.Parse(Console.ReadLine());
            var pancakes = int.Parse(Console.ReadLine());

            var moneyAmontForDay = (((cakes * 45) + (wafers * 5.80) + (pancakes * 3.20)) * cooks);
            var moneyFromTheWholeCapaing = (moneyAmontForDay * days);
            var moneyAfterCoverage = moneyFromTheWholeCapaing - (moneyFromTheWholeCapaing / 8);
            Console.WriteLine("{0:F2}", moneyAfterCoverage);
        }
    }
}
