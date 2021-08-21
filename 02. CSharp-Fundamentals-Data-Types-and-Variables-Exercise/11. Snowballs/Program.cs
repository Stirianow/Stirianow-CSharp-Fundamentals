using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger snowballValue = 0;
            int highestSnow = 0;
            int highestTime = 0;
            int highestQuality = 0;
            for (int i = 0; i < num; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (currentSnowballValue > snowballValue)
                {
                    highestSnow = snowballSnow;
                    highestTime = snowballTime;
                    highestQuality = snowballQuality;
                    snowballValue = currentSnowballValue;
                }
            }
            Console.WriteLine($"{highestSnow} : {highestTime} = {snowballValue} ({highestQuality})");


        }
    }
}
