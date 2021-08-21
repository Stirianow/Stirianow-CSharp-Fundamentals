using System;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmpPerHour = int.Parse(Console.ReadLine());
            int secondEmpPerHour = int.Parse(Console.ReadLine());
            int thirdEmpPerHour = int.Parse(Console.ReadLine());
            double peopleCount = double.Parse(Console.ReadLine());

            int peoplePerHour = firstEmpPerHour + secondEmpPerHour + thirdEmpPerHour;
            int hoursCount = 0;
            while (peopleCount > 0)
            {
                hoursCount++;
                if (hoursCount % 4 != 0)
                {
                    peopleCount -= peoplePerHour;
                }
            }
            Console.WriteLine($"Time needed: {hoursCount}h.");
        }
    }
}
