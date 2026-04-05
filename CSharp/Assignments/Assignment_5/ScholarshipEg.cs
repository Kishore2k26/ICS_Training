using System;

namespace ScholarshipApp
{
    class NoScholarshipException : Exception
    {
        public NoScholarshipException(string message): base(message)
        {
        }
    }

    class Scholarship
    {
        public double Merit(int marks, double fees)
        {
            double scholarshipAmount;

            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = fees * 0.20;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = fees * 0.30;
            }
            else if (marks > 90)
            {
                scholarshipAmount = fees * 0.50;
            }
            else
            {
                throw new NoScholarshipException("Student is not eligible for scholarship");
            }

            return scholarshipAmount;
        }
    }

    internal class ScholarshipEg
    {
        static void Main(string[] args)
        {
            Scholarship s = new Scholarship();

            try
            {
                int marks = 75;
                double fees = 50000;

                double amount = s.Merit(marks, fees);

                Console.WriteLine("Scholarship Amount: " + amount);
            }
            catch (NoScholarshipException e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }

            Console.ReadLine();
        }
    }
}