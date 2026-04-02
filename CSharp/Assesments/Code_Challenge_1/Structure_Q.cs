using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    internal class Structure_Q
    {
        struct DateOfBirth
        {
            public int day;
            public int month;
            public int year;
        }

        struct Employee
        {
            public string name;
            public DateOfBirth dob;
        }

        static void Main()
        {
            Employee[] emp = new Employee[2];

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Name of the employee : ");
                emp[i].name = Console.ReadLine();

                Console.Write("Input day of the birth : ");
                emp[i].dob.day = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input month of the birth : ");
                emp[i].dob.month = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input year for the birth : ");
                emp[i].dob.year = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();
            }

            Console.WriteLine("\nEmployee Details:");
            Console.WriteLine("-------------------");

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Employee Name : " + emp[i].name);
                Console.WriteLine("Date of Birth : {0}/{1}/{2}", emp[i].dob.day, emp[i].dob.month, emp[i].dob.year);
                Console.WriteLine("----------------------");
            }
        }
    }
}
