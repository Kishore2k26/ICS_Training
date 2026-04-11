using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_7
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpCity { get; set; }
        public int EmpSalary { get; set; }
    }

    static class EmployeeHelper
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>()
            {
                new Employee { EmpId = 1, EmpName = "Ravi", EmpCity = "Bangalore", EmpSalary = 50000 },
                new Employee { EmpId = 2, EmpName = "Anita", EmpCity = "Chennai", EmpSalary = 42000 },
                new Employee { EmpId = 3, EmpName = "Kiran", EmpCity = "Bangalore", EmpSalary = 60000 },
                new Employee { EmpId = 4, EmpName = "Suman", EmpCity = "Hyderabad", EmpSalary = 45000 },
                new Employee { EmpId = 5, EmpName = "Deepa", EmpCity = "Bangalore", EmpSalary = 48000 }
            };
        }

        public static void DisplayAllEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nAll Employees:");
            foreach (var emp in employees)
            {
                Display(emp);
            }
        }

        public static void DisplayHighSalaryEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees with Salary > 45000:");
            var result = employees.Where(e => e.EmpSalary > 45000);

            foreach (var emp in result)
            {
                Display(emp);
            }
        }

        public static void DisplayBangaloreEmployees(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees from Bangalore:");
            var result = employees.Where(e => e.EmpCity == "Bangalore");

            foreach (var emp in result)
            {
                Display(emp);
            }
        }

        public static void DisplayEmployeesSortedByName(List<Employee> employees)
        {
            Console.WriteLine("\nEmployees Sorted by Name (Ascending):");
            var result = employees.OrderBy(e => e.EmpName);

            foreach (var emp in result)
            {
                Display(emp);
            }
        }

        private static void Display(Employee emp)
        {
            Console.WriteLine($"Id: {emp.EmpId}, Name: {emp.EmpName}, City: {emp.EmpCity}, Salary: {emp.EmpSalary}");
        }
    }

    internal class Employeelist
    {
        static void Main(string[] args)
        {
            List<Employee> employees = EmployeeHelper.GetEmployees();

            EmployeeHelper.DisplayAllEmployees(employees);
            EmployeeHelper.DisplayHighSalaryEmployees(employees);
            EmployeeHelper.DisplayBangaloreEmployees(employees);
            EmployeeHelper.DisplayEmployeesSortedByName(employees);

            Console.Read();
        }
    }
}