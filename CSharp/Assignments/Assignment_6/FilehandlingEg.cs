using System;
using System.IO;

namespace Assignment_6
{
    internal class FilehandlingEg
    {
        static void Main()
        {
            string filePath = "data.txt";

            string[] lines =
            {
                "C# Programming",
                "File Handling",
                "Beginner Example"
            };

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Data written to file.\n");

            string[] readLines = File.ReadAllLines(filePath);

            Console.WriteLine("Reading from file:");
            foreach (string line in readLines)
            {
                Console.WriteLine(line);
            }

            Console.ReadLine();
        }
    }
}