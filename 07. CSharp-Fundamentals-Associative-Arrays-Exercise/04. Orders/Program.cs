using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var storage = new Dictionary<string, double[]>();
            while (input != "buy")
            {
                string[] currentInput = input.Split();
                string productName = currentInput[0];
                double price = double.Parse(currentInput[1]);
                int qty = int.Parse(currentInput[2]);
                if (!storage.ContainsKey(productName))
                {
                    storage.Add(productName, new double[2]);
                }
                double previousQty = storage[productName][1];
                double[] priceQty = new double[] { price, previousQty + qty };
                storage[productName] = priceQty;

                input = Console.ReadLine();
            }
            foreach (var item in storage)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
