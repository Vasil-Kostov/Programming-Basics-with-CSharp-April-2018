using System;

namespace Volleyball
{
    class StartUp
    {
        static void Main()
        {
            var year = Console.ReadLine().ToLower();
            var holydays = int.Parse(Console.ReadLine());
            var homeVisits = int.Parse(Console.ReadLine());

            var gamesInSofia = (48 - homeVisits) * 0.75;
            var gamesInHome = homeVisits;
            var gamesInHolidays = holydays * 2.0 / 3;

            if (year == "leap")
            {
                Console.WriteLine(Math.Truncate((gamesInHolidays + gamesInHome + gamesInSofia) * 1.15));
            }
            else
            {
                Console.WriteLine(Math.Truncate(gamesInHolidays + gamesInHome + gamesInSofia));
            }
        }
    }
}
