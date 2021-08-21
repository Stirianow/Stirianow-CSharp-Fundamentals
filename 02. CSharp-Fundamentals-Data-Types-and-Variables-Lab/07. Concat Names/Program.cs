using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string fiirstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.WriteLine($"{fiirstName}{delimiter}{lastName}");
        }
    }
}
