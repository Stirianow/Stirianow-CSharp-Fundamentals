using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startASCIINum = int.Parse(Console.ReadLine());
            int stopASCIINum = int.Parse(Console.ReadLine());
            for (int i = startASCIINum; i <= stopASCIINum; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
