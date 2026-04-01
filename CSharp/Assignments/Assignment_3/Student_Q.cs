using System;

namespace Assignment_3
{
    class Student
    {
        int rollno;
        string name;
        string className;
        int sem;
        string branch;
        int[] marks = new int[5];

        public Student(int rollno, string name, string className, int sem, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.className = className;
            this.sem = sem;
            this.branch = branch;
        }

        public void GetMarks(int m1, int m2, int m3, int m4, int m5)
        {
            marks[0] = m1;
            marks[1] = m2;
            marks[2] = m3;
            marks[3] = m4;
            marks[4] = m5;
        }

        public void DisplayResult()
        {
            int total = 0;
            bool fail = false;

            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                    fail = true;
                total += marks[i];
            }

            double avg = total / 5.0;

            if (fail || avg < 50)
                Console.WriteLine("Result: Failed");
            else
                Console.WriteLine("Result: Passed");
        }

        public void DisplayData()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(className);
            Console.WriteLine(sem);
            Console.WriteLine(branch);
            for (int i = 0; i < 5; i++)
                Console.WriteLine(marks[i]);
        }
    }

    internal class Student_Q
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Ravi", "BCA", 3, "CS");
            s.GetMarks(60, 55, 70, 48, 66);
            s.DisplayData();
            s.DisplayResult();
        }
    }
}