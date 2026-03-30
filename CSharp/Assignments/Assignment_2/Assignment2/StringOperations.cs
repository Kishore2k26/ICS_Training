using System;

namespace Assignment2
{
    public class StringOperations
    {
        public static void LengthOfWord()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            Console.WriteLine("Length: " + word.Length);
        }

        public static void ReverseWord()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            char[] arr = word.ToCharArray();
            Array.Reverse(arr);

            Console.WriteLine("Reversed: " + new string(arr));
        }

        public static void SameOrDiff()
        {
            Console.Write("Enter first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2))
                Console.WriteLine("SAME");
            else
                Console.WriteLine("DIFFERENT");
        }
    }
}