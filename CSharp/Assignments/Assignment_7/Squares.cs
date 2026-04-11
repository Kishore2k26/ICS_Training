using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Squares
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {7, 2, 30};

            var result = numbers.Where(n => n * n > 20).Select(n => n + " - " + (n * n));

            foreach (var num in result)
            {
                Console.WriteLine(num);
            }
        }
    }
}
