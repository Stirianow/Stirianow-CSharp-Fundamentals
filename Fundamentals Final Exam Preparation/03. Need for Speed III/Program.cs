using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> carList = new Dictionary<string, int[]>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("|");
                string car = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);
                carList.Add(car, new int[2]);
                carList[car][0] = mileage;
                carList[car][1] = fuel;
            }
            string[] command = Console.ReadLine().Split(" : ");
            while (command[0] != "Stop")
            {
                //Drive: { car} : { distance} : { fuel}
                if (command[0] == "Drive")
                {
                    string currentCar = command[1];
                    int distance = int.Parse(command[2]);
                    int fuelNedded = int.Parse(command[3]);
                    if (fuelNedded > carList[currentCar][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carList[currentCar][1] -= fuelNedded;
                        carList[currentCar][0] += distance;
                        Console.WriteLine($"{currentCar} driven for {distance} kilometers. {fuelNedded} liters of fuel consumed.");
                        if (carList[currentCar][0] >= 100000)
                        {
                            Console.WriteLine($"Time to sell the {currentCar}!");
                            carList.Remove(currentCar);
                        }
                    }
                }
                //Refuel: { car} : { fuel}
                if (command[0] == "Refuel")
                {
                    string currentCar = command[1];
                    int fuelAdded = int.Parse(command[2]);
                    if (carList[currentCar][1] + fuelAdded > 75)
                    {
                        int oldFuel = carList[currentCar][1];
                        carList[currentCar][1] = 75;
                        Console.WriteLine($"{currentCar} refueled with {75 - oldFuel} liters");
                    }
                    else
                    {
                        carList[currentCar][1] += fuelAdded;
                        Console.WriteLine($"{currentCar} refueled with {fuelAdded} liters");
                    }
                }
                //Revert: { car} : { kilometers}
                if (command[0] == "Revert")
                {
                    string currentCar = command[1];
                    int mileageReverted = int.Parse(command[2]);
                    if (carList[currentCar][0] - mileageReverted <= 10000)
                    {
                        carList[currentCar][0] = 10000;
                    }
                    else
                    {
                        carList[currentCar][0] -= mileageReverted;
                        Console.WriteLine($"{currentCar} mileage decreased by {mileageReverted} kilometers");
                    }
                }
                command = Console.ReadLine().Split(" : ");
            }
            Dictionary<string, int[]> sortedCarList = carList.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
            foreach (var car in sortedCarList)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {sortedCarList[car.Key][0]} kms, Fuel in the tank: {sortedCarList[car.Key][1]} lt.");
            }
        }
    }
}
