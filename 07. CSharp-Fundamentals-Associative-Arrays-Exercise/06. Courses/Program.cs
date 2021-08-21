using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var courseList = new Dictionary<string, List<string>>();
            while (input != "end")
            {
                string[] currentInput = input.Split(" : ");
                string courseName = currentInput[0];
                string studentName = currentInput[1];
                if (courseList.ContainsKey(courseName))
                {
                    courseList[courseName].Add(studentName);
                    courseList[courseName].Sort();
                }
                else
                {
                    courseList.Add(courseName, new List<string>());
                    courseList[courseName].Add(studentName);
                }
                input = Console.ReadLine();
            }
            var sortedDict = from entry in courseList orderby entry.Value.Count descending select entry;
            foreach (var course in sortedDict)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
