using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfUsers = int.Parse(Console.ReadLine());
            var parkingList = new Dictionary<string, string>();
            for (int i = 0; i < numOfUsers; i++)
            {
                string[] command = Console.ReadLine().Split();
                string user = command[1];
               
                if (command[0] == "register")
                {
                    if (!parkingList.ContainsKey(user))
                    {
                        parkingList.Add(user, command[2]);
                        Console.WriteLine($"{user} registered {command[2]} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingList[user]}");
                    }
                }
                if (command[0] == "unregister")
                {
                    if (parkingList.ContainsKey(user))
                    {
                        parkingList.Remove(user);
                        Console.WriteLine($"{user} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {user} not found");
                    }
                }
            }
            foreach (var user in parkingList)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
