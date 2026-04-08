using System;
using System.Collections.Generic;

namespace Code_Challenge_2
{
    class Products
    {
        public int product_id;
        public string product_name;
        public double product_price;
    }

    internal class Q2_Products
    {
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();

            for (int i = 0; i < 10; i++)
            {
                Products p = new Products();

                Console.WriteLine("Enter product id:" + (i+1));
                p.product_id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter product name:" + (i+1));
                p.product_name = Console.ReadLine();

                Console.WriteLine("Enter product price:" + (i+1));
                p.product_price = Convert.ToDouble(Console.ReadLine());

                products.Add(p);
            }

            for (int i = 0; i < products.Count - 1; i++)
            {
                for (int j = i + 1; j < products.Count; j++)
                {
                    if (products[i].product_price > products[j].product_price)
                    {
                        Products temp = products[i];
                        products[i] = products[j];
                        products[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted Products by Price:");
            foreach (Products p in products)
            {
                Console.WriteLine("P_Id: "+ p.product_id + "," + "P_Name: " + p.product_name + "," +"P_Price: "+ p.product_price);
            }

            Console.Read();
        }
    }
}