using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    internal class Q4_Delegates
    {
        delegate int CalciDel(int x, int y);

        static void Calculate(int x, int y, CalciDel ops)
        {
            int result = ops(x, y);
            Console.WriteLine(result);
        }

        static void Main()
        {
            Console.Write("Enter first number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition:");
            Calculate(a, b, Add);

            Console.WriteLine("Subtraction:");
            Calculate(a, b, Subtract);

            Console.WriteLine("Multiplication:");
            Calculate(a, b, Multiply);

            Console.ReadLine();

        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
