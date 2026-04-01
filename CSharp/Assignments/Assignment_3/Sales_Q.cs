using System;

namespace Assignment_3
{
    class SaleDetails
    {
        int salesNo;
        int productNo;
        double price;
        string dateOfSale;
        int qty;
        double totalAmount;

        public SaleDetails(int salesNo, int productNo, double price, int qty, string dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;
        }

        public void Sales()
        {
            totalAmount = qty * price;
        }

        public static void ShowData(SaleDetails s)
        {
            Console.WriteLine(s.salesNo);
            Console.WriteLine(s.productNo);
            Console.WriteLine(s.price);
            Console.WriteLine(s.qty);
            Console.WriteLine(s.dateOfSale);
            Console.WriteLine(s.totalAmount);
        }
    }

    internal class Sales_Q
    {
        static void Main(string[] args)
        {
            SaleDetails sd = new SaleDetails(1, 2001, 150, 4, "01-04-2026");
            sd.Sales();
            SaleDetails.ShowData(sd);
        }
    }
}