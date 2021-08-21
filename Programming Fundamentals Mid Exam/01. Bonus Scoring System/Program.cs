using System;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double studentsCount = double.Parse(Console.ReadLine());
            double lecturesCount = double.Parse(Console.ReadLine());
            double bonus = double.Parse(Console.ReadLine());
            double maxAttendance = 0;
            double maxBonus = 0;
            for (int i = 0; i < studentsCount; i++)
            {
                double attendance = double.Parse(Console.ReadLine());
                double currentBonus = attendance / lecturesCount * (5 + bonus);

                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendance = attendance;
                }
                //if (attendance > maxAttendance)
                //{
                //    maxAttendance = attendance;
                //}
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
