/*
Construct a C# program for a basic inventory system. Define a class named Product with properties ProductName 
and Price. Implement a parameterized constructor to initialize these properties. Instantiate objects using the 
constructor and display the product details.
*/

using System;

namespace InventorySystem
{

    class Product
    {
        public string productName { get; set; }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string productN, int prices)
        {
            productName = productN;
            Price = prices;

        }

        static void Main(string[] args)
        {
            Product pro1 = new Product("Apple", 777);
            Product pro2 = new Product("Orange", 789);

            Console.WriteLine("Product 1 = " + pro1.productName + ", " + "Price = $" + pro1.price);
            Console.WriteLine("Product 2 = " + pro2.productName + ", " + "Price = $" + pro2.price);

            Console.ReadKey();
        }
    }

}


