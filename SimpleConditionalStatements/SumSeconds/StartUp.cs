using System;

namespace SumSeconds
{
    class StartUp
    {
        static void Main()
        {
            var firstSeconds = int.Parse(Console.ReadLine());
            var secondSeconds = int.Parse(Console.ReadLine());
            var thirdSeconds = int.Parse(Console.ReadLine());

            var secondsSum = firstSeconds + secondSeconds + thirdSeconds;
            int minutes = 0;
            for (int i = secondsSum; i > 59; i -= 60)
            {
                minutes += 1;
                secondsSum -= 60;
            }
            if (secondsSum < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, secondsSum);
            }
            else
            {
                Console.WriteLine("{0}:{1}", minutes, secondsSum);
            }
        }
    }
}
