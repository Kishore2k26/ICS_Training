using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compare();
            PosNeg();
            All_Operations();
            Multiplication_Table();
            SumofIntegers();
        }

        public static void Compare()
        {
            int a, b;

            Console.WriteLine("Check whether both are equal");

            Console.Write("Input 1st number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input 2nd number:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine($"{a} and {b} are equal.");
            }
            else
            {
                Console.WriteLine($"{a} and {b} are not equal.");
            }

            Console.WriteLine("===============================");
        }

        public static void PosNeg()
        {
            int a;

            Console.WriteLine("Check whether it is +ve / -ve");

            Console.Write("Enter a number:");
            
            a = Convert.ToInt32(Console.ReadLine());

            if (a >= 0)
            {
                Console.WriteLine($"{a} is a positive number.");
            }
            else
            {
                Console.WriteLine($"{a} is a negative number.");
            }

            Console.WriteLine("===============================");
        }

        public static void All_Operations()
        {
            int a, b;

            Console.WriteLine("All Operations (+,-,*,/)");

            Console.Write("Input first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;

                case '-':
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;

                case '*':
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;

                case '/':
                    if (b != 0)
                        Console.WriteLine($"{a} / {b} = {a / (double)b}");
                    else
                        Console.WriteLine("Cannot divide by zero");
                    break;

                default:
                    Console.WriteLine("Invalid operation entered.");
                    break;
            }

            Console.WriteLine("===============================");
        }

        public static void Multiplication_Table()
        {
            int a;

            Console.WriteLine("Multiplication_Table");

            Console.Write("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{a} x {i} = {a * i}");
            }

            Console.WriteLine("===============================");
        }

        public static void SumofIntegers()
        {
            int a,b;

            Console.WriteLine("SumofIntegers");

            Console.Write("Input first number:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number:");
            b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine((a+b)*3);
            }
            else
            {
                Console.WriteLine(a+b);
            }

            Console.WriteLine("===============================");
        }
    }
}
