using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Heigth: ");
            double heigth = double.Parse(Console.ReadLine());
            double volume = (length + heigth + width) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
