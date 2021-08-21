using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            double bigestKeg = double.MinValue;
            string bigestKegName = string.Empty;
            for (int i = 1; i <= numberOfKegs; i++)
            {
                string nameOfKeg = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * radius * radius * height;
                if (bigestKeg < volume)
                {
                    bigestKeg = volume;
                    bigestKegName = nameOfKeg;
                }
            }
            Console.WriteLine(bigestKegName);
        }
    }
}
