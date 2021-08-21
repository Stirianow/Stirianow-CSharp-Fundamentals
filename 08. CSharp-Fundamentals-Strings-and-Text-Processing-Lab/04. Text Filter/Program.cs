using System;
using System.Text;
using System.Linq;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedList = Console.ReadLine().Split(", ");
            string inputText = Console.ReadLine();
            foreach (var word in bannedList)
            {
                inputText = inputText.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(inputText);
        }
    }
}
