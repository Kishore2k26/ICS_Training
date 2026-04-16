using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_3
{
    class CricketTeam
    {
        public void PointsCalculation(int no_of_matches)
        {
            int sum = 0;

            for (int i = 1; i <= no_of_matches; i++)
            {
                Console.Write($"Enter the score of the match {i}: ");
                sum += Convert.ToInt32(Console.ReadLine()); 
            }

            double average = sum / no_of_matches;

            Console.WriteLine("\nTotal No of Matches: " + no_of_matches);
            Console.WriteLine("Sum of the scores: " + sum);
            Console.WriteLine("Average score of all the matches: " + average);

        }
    }
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of matches: ");
            int n = Convert.ToInt32(Console.ReadLine());

            CricketTeam team = new CricketTeam();
            team.PointsCalculation(n);
        }
    }
}
