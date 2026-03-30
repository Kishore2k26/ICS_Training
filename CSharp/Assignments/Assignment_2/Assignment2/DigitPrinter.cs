using System;

namespace Assignment2
{
    public class DigitPrinter
    {
        public static void PrintDigit()
        {
            Console.Write("Enter a digit: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("{0} {0} {0} {0}", num);
                Console.WriteLine("{0}{0}{0}{0}", num);
            }
        }
    }
}