using System;

namespace PrintSequence
{
    class Program
    {
        static void Main()
        {
            for (int a = 2; a < 12; a++)
            {
                if (a%2==0)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine(-a);
                }
            }
        }
    }
}
