using System;

namespace BitExchange
{
    class Startup
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint[] bit = new uint[6];
            bit[0] = ((number >> 3) & 1);
            bit[1] = ((number >> 4) & 1);
            bit[2] = ((number >> 5) & 1);
            bit[3] = ((number >> 24) & 1);
            bit[4] = ((number >> 25) & 1);
            bit[5] = ((number >> 26) & 1);



            for (int i = 0; i < 3; i++)
            {
                if (bit[i] == 0)
                {

                }
            }
            
            Console.WriteLine(number);
        }
    }
}
