using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var studentList = new Dictionary<string, List<double>>();
            for (int i = 0; i < input; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentList.ContainsKey(studentName))
                {
                    studentList.Add(studentName, new List<double>());
                }
                studentList[studentName].Add(grade);
            }
            studentList = studentList.Where(s => s.Value.Average() >= 4.5).ToDictionary(s => s.Key, s => s.Value);
            foreach (var student in studentList.OrderByDescending(s => s.Value.Average()))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
