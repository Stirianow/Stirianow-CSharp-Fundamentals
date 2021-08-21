using System;
using System.Collections.Generic;

namespace _05._CSharp_Fundamentals_Lists_Lab.docx
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //string[] names = new string[n];
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
                //names[i] = name;
            }

            Console.WriteLine(string.Join(" ", names));

            //List<string> names = new List<string>();
            //names.Add("Peter");
            //names.Add("Maria");
            //names.Add("George");
            //foreach (string names in List)
            //{
            //    Console.WriteLine(name);
            //    Console.WriteLine(string.Join(" ", names));
            //}
        }
    }
}
