using System;
using System.Collections.Generic;

namespace Assignment_4
{
    internal class Q3_Stack
    {
        static void Main(string[] args)
        {
            Stack<int> originalStack = new Stack<int>();
            Stack<int> sortedStack = new Stack<int>();

            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                originalStack.Push(Convert.ToInt32(Console.ReadLine()));
            }

            while (originalStack.Count > 0)
            {
                int temp = originalStack.Pop();

                while (sortedStack.Count > 0 && sortedStack.Peek() > temp)
                {
                    originalStack.Push(sortedStack.Pop());
                }

                sortedStack.Push(temp);
            }

            Console.WriteLine("\nStack elements in descending order (Top to Bottom):");
            foreach (int item in sortedStack)
            {
                Console.Write(item + " ");
            }
        }
    }
}