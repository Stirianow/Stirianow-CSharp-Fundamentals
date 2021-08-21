using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTourists = int.Parse(Console.ReadLine());
            string typeOfTourists = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double priceForOne = 0;
            if (typeOfTourists == "Students")
            {
                if (weekDay == "Friday")
                {
                    priceForOne = 8.45;
                }
                else if (weekDay == "Saturday")
                {
                    priceForOne = 9.80;
                }
                else if (weekDay == "Sunday")
                {
                    priceForOne = 10.46;
                }
            }
            if (typeOfTourists == "Business")
            {
                if (weekDay == "Friday")
                {
                    priceForOne = 10.90;
                }
                else if (weekDay == "Saturday")
                {
                    priceForOne = 15.60;
                }
                else if (weekDay == "Sunday")
                {
                    priceForOne = 16;
                }
            }
            if (typeOfTourists == "Regular")
            {
                if (weekDay == "Friday")
                {
                    priceForOne = 15;
                }
                else if (weekDay == "Saturday")
                {
                    priceForOne = 20;
                }
                else if (weekDay == "Sunday")
                {
                    priceForOne = 22.50;
                }
            }
            double total = countOfTourists * priceForOne;
            if (typeOfTourists == "Students" && countOfTourists >=30)
            {
                total *= 0.85;
            }
            else if (typeOfTourists == "Business" && countOfTourists >= 100)
            {
                total = (countOfTourists - 10) * priceForOne;
            }
            else if (typeOfTourists == "Regular" && (countOfTourists >= 10 && countOfTourists < 20))
            {
                total *= 0.95;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
