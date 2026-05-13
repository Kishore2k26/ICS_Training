using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_SQL_CC
{
    internal class Q1
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dataReader = null;
        static void Main(string[] args)
        {
            SelectData();
            Console.WriteLine();
            InsertEmployee();
            Console.WriteLine();
            Console.WriteLine("Displaying the record after insertion");
            SelectData();
            Console.Read();
        }

        public static void InsertEmployee()
        {
            try
            {
                conn = getConnection();

                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Employee Salary: ");
                decimal salary = Convert.ToDecimal(Console.ReadLine());

                Console.Write("Enter Employee Type (F/P): ");
                string type = Console.ReadLine();


                cmd = new SqlCommand("Add_Employee", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Emp_name", name);
                cmd.Parameters.AddWithValue("@Emp_sal", salary);
                cmd.Parameters.AddWithValue("@Emp_type", type);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    Console.WriteLine("Employee inserted successfully!");
                }

                else
                {
                    Console.WriteLine("Could not Insert Record.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SelectData()
        {
            try
            {
                conn = getConnection();
                cmd = new SqlCommand("select * from Employee_Details");
                cmd.Connection = conn;
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader["Emp_no"] + " " + dataReader["Emp_name"] + "  " + 
                        dataReader["Emp_sal"] + " " + dataReader["Emp_type"]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        static SqlConnection getConnection()
        {
            conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; " +
                "Initial Catalog = Employee_Management;" +
                "Integrated Security = true ;");
            conn.Open();
            return conn;
        }
    }
}