using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileData
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\SwabhavTech\Yogeshwar.txt";
            if (!File.Exists(filepath))
            {
                File.Create(filepath);
            }
            Console.WriteLine("Enter string to store in file");
            string line = Console.ReadLine();
            File.AppendAllText(filepath, line);

            Console.WriteLine();
            Console.WriteLine("File contains:");
            Console.WriteLine(File.ReadAllText(filepath));

            Console.ReadLine();
        }
    }
}
