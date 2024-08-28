/*
3.	Imagine you are developing a console application to manage a shop's inventory. Design a class named "Product" to 
encapsulate product details while utilizing access specifiers appropriately. A parameterized constructor that 
initializes productId, productName, price, and quantityInStock when an object is created.


a)	Create an instance of the "Product" class, representing a product with an ID of 101, name "Laptop," price $800, 
and quantity in stock 10.
b)	Access and display the name, price, and quantity of the product.
c)	Attempt to modify the product's ID from external code (outside the class). Observe and comment on the result.

*/

using System;

namespace Employee
{
    class Product
    {
        public int productid { get; private set; }
        public string productname { get; }
        public double price { get; }
        public int quantitystock { get; private set; }

        public Product(int ProductId, string ProductName, double Price, int QuantityStock)
        {
            productid = ProductId;
            productname = ProductName;
            price = Price;
            quantitystock = QuantityStock;
        }

        public void AddProduct(int quantity)
        {
            quantitystock += quantity;
        }

        public void BuyProduct(int quantity)
        {
            if (quantity < quantitystock)
            {
                quantitystock = quantitystock - quantity;
            }
            else
            {
                Console.WriteLine("No enough quantity");
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            Product pro = new Product(101, "LapTop", 800, 10);
            Console.WriteLine("Name: " + pro.productname + "\n" + "Price: " + pro.price + "\n" + "Quantity: " + pro.quantitystock + "\n");

            Console.ReadKey();
        }
    }
}
