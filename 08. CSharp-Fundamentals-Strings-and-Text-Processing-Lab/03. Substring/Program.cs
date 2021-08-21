using System;
using System.Text;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            result.Append(secondString);

            while (result.ToString().Contains(firstString.ToLower()))
            {
                int startIndex = result.ToString().IndexOf(firstString.ToLower());

                result.Remove(startIndex, firstString.Length);
            }

            Console.WriteLine(result);
        }
    }
}
