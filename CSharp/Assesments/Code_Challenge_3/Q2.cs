using System;
using System.IO;

namespace Code_Challenge_3
{
    class fileappend
    {
        public void Appendtext(string text, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(text);
                }
                Console.WriteLine("File location: " + Path.GetFullPath(filePath));
            }

            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            finally
            {
                Console.WriteLine("Text appended successfully.");
            }
        }
    }
    internal class Q2
    {
        static void Main(string[] args)
        {
            string filePath = "SampleFile.txt";

            Console.WriteLine("Enter the text to append to the file:");
            string text = Console.ReadLine();

            fileappend appender = new fileappend();
            appender.Appendtext(text, filePath);
        }
    }
}
