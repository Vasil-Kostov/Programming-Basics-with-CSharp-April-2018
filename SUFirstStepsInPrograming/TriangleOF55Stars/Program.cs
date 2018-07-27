using System;

namespace TriangleOF55Stars
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                //for (int j = 0; j < i; j++)
                //{
                //    Console.Write('*');
                //}
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
