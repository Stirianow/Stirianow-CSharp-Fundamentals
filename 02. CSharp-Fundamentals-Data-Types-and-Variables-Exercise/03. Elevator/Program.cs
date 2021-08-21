using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            //int count = 0;
            //while (peopleCount > 0)
            //{
            //    peopleCount -= elevatorCapacity;
            //    count++;
            //}
            //Console.WriteLine(count);
            Console.WriteLine(Math.Ceiling((double)peopleCount / elevatorCapacity));
        }
    }
}
