using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDrink = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            TotalOrder(typeOfDrink, quantity);
        }

        static void TotalOrder(string typeOfDrink, int quantity)
        {
            double price = 0;
            switch (typeOfDrink)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
            }
            double totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
