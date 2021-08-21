using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = CalculateArea(height, width);
            Console.WriteLine(area);
        }

        static double CalculateArea(double h, double w)
        {
            return h * w; 
        }
    }
}
