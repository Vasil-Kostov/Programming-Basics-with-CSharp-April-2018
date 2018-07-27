using System;

namespace FourDigits
{
    class Starup
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] a = new int[4];
            for (int i = 0; i < 4; i++)
            {
                a[3 - i] = number % 10;
                sum += a[3 - i];
                number /= 10;
            }
            Console.WriteLine(sum);
            Console.WriteLine("{0}{1}{2}{3}", a[3], a[2], a[1], a[0]);
            Console.WriteLine("{0}{1}{2}{3}", a[3], a[0], a[1], a[2]);
            Console.WriteLine("{0}{1}{2}{3}", a[0], a[2], a[1], a[3]);
        }
    }
}
