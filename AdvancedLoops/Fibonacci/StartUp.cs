using System;

namespace Fibonacci
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int[] nums = new int[n + 1];
                nums[0] = 1;
                nums[1] = 1;
                for (int i = 2; i <= n; i++)
                {
                    nums[i] = nums[i - 1] + nums[i - 2];
                }
                Console.WriteLine(nums[n]);
            }
            
        }
    }
}
