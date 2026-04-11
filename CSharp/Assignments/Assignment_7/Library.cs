using System;

namespace Assignment_7
{
    public static class ConcessionHelper
    {
        public const int TotalFare = 500;
        public static void CalculateConcession(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs - Free Ticket");
            }
            else if (age > 60)
            {
                double concession = TotalFare * 0.30;
                double finalFare = TotalFare - concession;

                Console.WriteLine("Senior Citizen - Fare after concession: " + finalFare);
            }
            else
            {
                Console.WriteLine("Ticket Booked - Fare: " + TotalFare);
            }
        }
    }

    internal class Library
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            ConcessionHelper.CalculateConcession(age);

            Console.Read();
        }
    }
}