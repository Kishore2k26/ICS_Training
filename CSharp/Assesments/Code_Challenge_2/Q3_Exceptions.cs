using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    internal class Q3_Exceptions
    {
        static void CheckNumber(int number)
        {
            if (number < 0)
            {
                throw new Exception("Number cannot be negative.");
            }

            Console.WriteLine("You entered a valid number: " + number);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number:");
                int number = Convert.ToInt32(Console.ReadLine());
                
                CheckNumber(number);
            }

            catch(Exception e) 
            {
                Console.WriteLine("Error: "+e.Message);
            }
            
            Console.Read();
        }
    }
}
