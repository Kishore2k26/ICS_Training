using System;

namespace Assignment_4
{
    internal class Q1_String
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.Write("Enter a position to remove the character from the word: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int index = num - 1;

            string result = word.Remove(index, 1);
            Console.WriteLine("Resulting word: " + result);
        }
    }
}