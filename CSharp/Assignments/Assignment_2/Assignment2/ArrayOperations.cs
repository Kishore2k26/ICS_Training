using System;
using System.Linq;

namespace Assignment2
{
    public class ArrayOperations
    {
        public static void ArrayDisplay()
        {
            int[] arr = new int[5];
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter a number: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            double average = (double)sum / arr.Length;

            Console.WriteLine("Average: " + average);
            Console.WriteLine("Max: " + arr.Max());
            Console.WriteLine("Min: " + arr.Min());
        }

        public static void TenMarks()
        {
            int[] arr = new int[10];
            int sum = 0;

            Console.WriteLine("Enter 10 numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Number {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
                sum += arr[i];
            }

            Array.Sort(arr);

            Console.WriteLine("Ascending:");
            foreach (int i in arr) Console.Write(i + " ");

            Array.Reverse(arr);

            Console.WriteLine("\nDescending:");
            foreach (int i in arr) Console.Write(i + " ");

            Console.WriteLine("\nTotal: " + sum);
            Console.WriteLine("Average: " + (double)sum / arr.Length);
        }

        public static void CopyArray()
        {
            int[] source = { 10, 20, 30, 40 };
            int[] destination = new int[source.Length];

            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            Console.WriteLine("Copied Array:");
            foreach (int num in destination)
                Console.Write(num + " ");
        }
    }
}