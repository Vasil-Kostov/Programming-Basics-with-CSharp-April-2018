using System;

namespace SpecialNumbers
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            bool special1, special2, special3, special4;
            special1 = special2 = special3 = special4 = false;

            for (int num1 = 1; num1 < 10; num1++)
            {
                if (n % num1 == 0) special1 = true;
                for (int num2 = 1; num2 < 10; num2++)
                {
                    if (n % num2 == 0) special2 = true;
                    for (int num3 = 1; num3 < 10; num3++)
                    {
                        if (n % num3 == 0) special3 = true;
                        for (int num4 = 1; num4 < 10; num4++)
                        {
                            if (n % num4 == 0) special4 = true;
                            if (special1 == true && special2 == true && special3 == true && special4 == true)
                            {
                                Console.Write("{0}{1}{2}{3} ", num1, num2, num3, num4);
                            }
                            special4 = false;
                        }
                        special3 = false;
                    }
                    special2 = false;
                }
                special1 = false;
            }
            Console.WriteLine();
        }
    }
}
