using System;
namespace N_
{
    class StartUp
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var nFactorial = 1;

            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            Console.WriteLine(nFactorial);
        }
    }
}
