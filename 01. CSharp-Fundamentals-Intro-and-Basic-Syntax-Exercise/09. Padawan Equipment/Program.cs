using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumPurchased = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            int freeBelt = studentsCount / 6;

            double sumForSabres = Math.Ceiling(studentsCount * 1.1) * sabrePrice;
            double sumForRobes = studentsCount * robePrice;
            double sumForBelts = beltPrice * (studentsCount - freeBelt);

            double totalSumNeeded = Math.Round((sumForBelts + sumForRobes + sumForSabres), 2);

            if (totalSumNeeded <= sumPurchased)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSumNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSumNeeded - sumPurchased:f2}lv more.");
            }

        }
    }
}
