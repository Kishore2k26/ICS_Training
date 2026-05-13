using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ADO_SQL_CC
{
    internal class Q2
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dataReader = null;
        static void Main(string[] args)
        {
            SelectData();
            UpdateSalary();

            Console.Write("Enter Employee number to display: ");
            int id = Convert.ToInt32(Console.ReadLine());

            DisplayUpdatedSalary(id);
            Console.WriteLine();
            Console.WriteLine("Displaying all the records");
            SelectData();

            Console.Read();
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

        public static void UpdateSalary()
        {
            try
            {
                conn = getConnection();

                Console.WriteLine();
                Console.Write("Enter Employee number to Update Salary: ");
                int empid = Convert.ToInt32(Console.ReadLine());

                cmd = new SqlCommand("Update_Salary", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Emp_no", empid);

                SqlParameter outParam = new SqlParameter("@Updated_Sal", SqlDbType.Decimal);
                outParam.Direction = ParameterDirection.Output;
                outParam.Precision = 10;
                outParam.Scale = 2;
                cmd.Parameters.Add(outParam);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Updated Salary: " + cmd.Parameters["@Updated_Sal"].Value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void DisplayUpdatedSalary(int empid)
        {
            try
            {
                conn = getConnection();

                cmd = new SqlCommand("select * from Employee_Details where Emp_no = @Emp_no", conn);
                cmd.Parameters.AddWithValue("@Emp_no", empid);

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Console.WriteLine(
                        dataReader["Emp_no"] + " " +
                        dataReader["Emp_name"] + " " +
                        dataReader["Emp_sal"] + " " +
                        dataReader["Emp_type"]);
                }
            }
            catch (Exception ex)
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