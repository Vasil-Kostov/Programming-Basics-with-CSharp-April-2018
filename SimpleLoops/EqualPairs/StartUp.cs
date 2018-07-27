using System;

namespace EqualPairs
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var firsA = double.Parse(Console.ReadLine());
            var firstB = double.Parse(Console.ReadLine());
            var firstPairSum = firsA + firstB;
            var previousPairSum = firstPairSum;
            var maxPairDifference = 0d;

            for (int i = 0; i < n - 1; i++)
            {
                double momentSum = 0;
                for (int j = 0; j < 2; j++)
                {
                    momentSum += double.Parse(Console.ReadLine());
                }
                if (previousPairSum != momentSum)
                {
                    if (maxPairDifference < Math.Abs(previousPairSum - momentSum))
                    {
                        maxPairDifference = Math.Abs(previousPairSum - momentSum);
                    }
                    previousPairSum = momentSum;
                }
                else
                {
                    previousPairSum = momentSum;
                }
            }

            if (maxPairDifference == 0)
            {
                Console.WriteLine("Yes, value={0}", firstPairSum);
            }
            else
            {
                Console.WriteLine("No, MaxDiff={0}", maxPairDifference);
            }
            
        }
    }
}
