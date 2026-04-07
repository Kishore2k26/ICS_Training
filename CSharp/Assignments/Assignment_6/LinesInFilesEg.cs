using System;
using System.IO;

namespace Assignment_6
{ 
    class LinesInFilesEg
    {
        static void Main()
        {
            string filePath = "data.txt";

            string[] lines = File.ReadAllLines(filePath);

            int count = lines.Length;

            Console.WriteLine("Number of lines in the file: " + count);

            Console.ReadLine();
        }
    }
}