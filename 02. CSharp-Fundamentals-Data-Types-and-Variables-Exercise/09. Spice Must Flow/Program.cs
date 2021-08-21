using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint yieldPerDay = uint.Parse(Console.ReadLine());
            uint totalYield = 0;
            uint counter = 0;
            while (yieldPerDay >= 100)
            {
                uint currentYield = yieldPerDay - 26;
                totalYield += currentYield;
                yieldPerDay -= 10;
                counter++;
            }
            if (counter > 0)
            {
                totalYield -= 26;
            }
            Console.WriteLine(counter);
            Console.WriteLine(totalYield);

        }
    }
}
