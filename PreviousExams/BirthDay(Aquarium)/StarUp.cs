using System;

namespace BirthDay_Aquarium_
{
    class StarUp
    {
        static void Main()
        {
            var lenght = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var hight = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());
            
            var aquariumVolume = lenght * width * hight;
            var volumeInLitres = aquariumVolume / 1000d;

            Console.WriteLine("{0:F3}", (volumeInLitres * (1 - (percent /100))));
        }
    }
}
