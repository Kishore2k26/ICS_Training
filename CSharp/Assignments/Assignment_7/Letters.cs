using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Letters
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
            {
                "mum",
                "amsterdam",
                "bloom"
            };

            var result = words.Where(word => word.StartsWith("a") && word.EndsWith("m"));

            foreach (string word in result)
            {
                Console.WriteLine(word);
            }
        }


    }
}
