using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_2
{
    abstract class Student
    {
        public string S_Name;
        public int S_Id;
        public double S_Grade;

        public abstract bool IsPassed(double S_Grade);
    }

    class Undergraduate : Student
    {
        public override bool IsPassed(double S_Grade)
        {
            if (S_Grade > 70)
                return true;
            else
                return false;
        }
    }

    class Postgraduate : Student
    {
        public override bool IsPassed(double S_Grade)
        {
            if (S_Grade > 80)
                return true;
            else
                return false;
        }
    }

    internal class Q1_Students
    {
        static void Main()
        {
            Undergraduate ug = new Undergraduate();
            ug.S_Name = "Ramu";
            ug.S_Id = 101;
            ug.S_Grade = 70;

            Console.WriteLine("Undergraduate Student");
            Console.WriteLine("Passed: " + ug.IsPassed(ug.S_Grade));

            Console.WriteLine();

            Postgraduate pg = new Postgraduate();
            pg.S_Name = "Somu";
            pg.S_Id = 201;
            pg.S_Grade = 90;

            Console.WriteLine("Graduate Student");
            Console.WriteLine("Passed: " + pg.IsPassed(pg.S_Grade));

            Console.Read();

        }
    }
}
