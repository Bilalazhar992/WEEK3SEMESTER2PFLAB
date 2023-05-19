using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3pflab
{
    public class Store
    {
        public string product_name;
        public string product_category;
        public int product_price;
        public int Stock_quantity;
        public int Minimum_quantity;
        public void AddProduct()
        {
            Console.WriteLine("Enter Product Name: ");
            product_name = Console.ReadLine();
            Console.WriteLine("Enter Product Category: ");
            product_category = Console.ReadLine();
            Console.WriteLine("Enter Product Price: ");
            product_price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Stock: ");
            Stock_quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minimum Quantity");
            Minimum_quantity = int.Parse(Console.ReadLine());
        }
        public float CalculateTax()
        {
            float tax=0.0F;
            if(product_category=="Grocerry")
            {
                tax =product_price * 0.1F;
            }
            if (product_category == "Fruit")
            {
                tax = product_price * 0.05F;
            }
            else
            {
                tax = product_price * 0.15F;
            }
            return tax;
        }
        public bool Objecttobeordered()
        {
            if(Stock_quantity<Minimum_quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

