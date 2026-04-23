using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenge_4
{
    interface IReport
    {
        void GenerateReport();
    }

    class ChartReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Chart Report Generated.");
        }
    }

    class TabularReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Tabular Report Generated.");
        }
    }

    class SummaryReport : IReport
    {
        public void GenerateReport()
        {
            Console.WriteLine("Summary Report Generated.");
        }
    }

    class ReportFactory
    {
        public static IReport GetReport(string choice)
        {
            if (choice == "chart")
            {
                return new ChartReport();
            }
            else if (choice == "tabular")
            {
                return new TabularReport();
            }
            else if (choice == "summary")
            {
                return new SummaryReport();
            }
            else
            { 
                throw new Exception("Invalid Report Type");
            }

        }
    }

    internal class Q2_Report
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter report type (chart/tabular/summary):");
            string choice = Console.ReadLine();

            try
            {
                IReport report = ReportFactory.GetReport(choice);
                report.GenerateReport();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}