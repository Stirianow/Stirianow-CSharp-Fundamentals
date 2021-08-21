using System;
using System.IO;
using System.Text;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullpath = Console.ReadLine();

            var filename = Path.GetFileNameWithoutExtension(fullpath);
            var ext = Path.GetExtension(fullpath);
            string extension = ext.Substring(1);
            Console.WriteLine($"File name: {filename}");
            Console.WriteLine($"File extension: {extension}");

            //int slash = fullpath.LastIndexOf('\\');
            //string file = fullpath.Substring(slash+1);
            //int dot = file.LastIndexOf('.');
            //string filename = file.Substring(0, dot);
            //string extension = file.Substring(dot+1);
            //Console.WriteLine($"File name: {filename}");
            //Console.WriteLine($"File extension: {extension}");
        }
    }
}
