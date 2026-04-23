using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    class Distance
    {
        public int Kilometer { get; set; }

        public Distance(int km)
        {
            Kilometer = km;
        }

        public static Distance Add(Distance d1, Distance d2)
        {
            return new Distance(d1.Kilometer + d2.Kilometer);
        }
    }

    internal class Q1_Distance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first distance in kilometers:");
            int km1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter second distance in kilometers:");
            int km2 = Convert.ToInt32(Console.ReadLine());

            Distance d1 = new Distance(km1);
            Distance d2 = new Distance(km2);

            Distance d3 = Distance.Add(d1, d2);

            Console.WriteLine("Total Distance: " + d3.Kilometer + " Km");

            Console.Read();
        }
    }
}
