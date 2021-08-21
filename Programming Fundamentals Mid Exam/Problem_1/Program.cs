using System;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededEx = double.Parse(Console.ReadLine());
            int battlesCount = int.Parse(Console.ReadLine());
            double totalEx = 0;
            bool isCollected = false;
            int counter = 0;
            for (int i = 1; i <= battlesCount; i++)
            {
                double currentEx = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    currentEx *= 1.15;
                }
                else if (i % 5 == 0)
                {
                    currentEx *= 0.90;
                }
                if (i % 15 == 0)
                {
                    currentEx *= 1.05;
                }
                totalEx += currentEx;
                counter++;
                if (totalEx >= neededEx)
                {
                    isCollected = true;
                    break;
                }
            }
            if (isCollected)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {counter} battles.");
            }
            else
            {
                double leftEx = neededEx - totalEx;
                Console.WriteLine($"Player was not able to collect the needed experience, {leftEx:f2} more needed.");
            }
        }
    }
}
