using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_1
{
    internal class Emp_Manage
    {
        class Employee 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Department {  get; set; }
            public double Salary { get; set; }
        }

        class Program
        {
            static List<Employee> employees = new List<Employee>();
            static void Main(string[] args)
            {
                int choice;

                do
                {
                    Console.WriteLine("*** Menu ***");
                    Console.WriteLine("1. Add Employee");
                    Console.WriteLine("2. View All Employees");
                    Console.WriteLine("3. Search Employee By Id");
                    Console.WriteLine("4. Update Employee");
                    Console.WriteLine("5. Delete Employee");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("*** End ***");
                    Console.WriteLine();

                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1: AddEmployee(); break;
                        case 2: ViewAllEmployees(); break;
                        case 3: SearchEmployeeById(); break;
                        case 4: UpdateEmployee(); break;
                        case 5: DeleteEmployee(); break;
                        case 6: Console.WriteLine("Exiting the Console, Thank You."); break;
                        default: Console.WriteLine("Invalid choice. Please try again."); break;
                    }

                }
                while (choice != 6);
            }

            static void AddEmployee()
            {
                Employee emp = new Employee();

                Console.Write("Enter Employee Id: ");
                emp.Id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee Name: ");
                emp.Name = Console.ReadLine();

                Console.Write("Enter Employee Department: ");
                emp.Department = Console.ReadLine();

                Console.Write("Enter Employee Salary: ");
                emp.Salary = Convert.ToDouble(Console.ReadLine());

                employees.Add(emp);
                Console.WriteLine("*** Employee added successfully.*** ");
                Console.WriteLine("--------------------------------------");
            }

            static void ViewAllEmployees()
            {
                Console.WriteLine("Employee List:");

                foreach (var emp in employees)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
                }
                Console.WriteLine("--------------------------------------");
            }

            static void SearchEmployeeById()
            {
                Console.Write("Enter Employee Id to search: ");

                int id = Convert.ToInt32(Console.ReadLine());
                var emp = employees.Find(e => e.Id == id);

                if (emp != null)
                {
                    Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
                Console.WriteLine("--------------------------------------");
            }

            static void UpdateEmployee()
            {
                Console.Write("Enter Employee Id to update: ");

                int id = Convert.ToInt32(Console.ReadLine());
                var emp = employees.Find(e => e.Id == id);

                if (emp != null)
                {
                    Console.Write("Enter new Employee Name: ");
                    emp.Name = Console.ReadLine();

                    Console.Write("Enter new Employee Department: ");
                    emp.Department = Console.ReadLine();

                    Console.Write("Enter new Employee Salary: ");
                    emp.Salary = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Employee updated successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
                Console.WriteLine("--------------------------------------");
            }

            static void DeleteEmployee()
            {
                Console.Write("Enter Employee Id to delete: ");

                int id = Convert.ToInt32(Console.ReadLine());
                var emp = employees.Find(e => e.Id == id);

                if (emp != null)
                {
                    employees.Remove(emp);
                    Console.WriteLine("Employee deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Employee not found.");
                }
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
