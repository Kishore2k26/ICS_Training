using System;

namespace Assignment2
{
    enum Days
    {
        Sunday = 0,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public class DayConverter
    {
        public static void DayAsWord()
        {
            Console.Write("Enter a day number (0-6): ");
            int day = int.Parse(Console.ReadLine());

            if (day >= 0 && day <= 6)
                Console.WriteLine((Days)day);
            else
                Console.WriteLine("Invalid day number");
        }
    }
}