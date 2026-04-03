using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Q2_String
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (word.Length > 1)
            {
                string result = word.Substring(1, word.Length - 2);
                Console.WriteLine("Resulting word: " + result);
            }
            else
            {
                Console.WriteLine("String is too short");
            }

        }
    }
}
