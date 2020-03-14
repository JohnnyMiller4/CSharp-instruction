using System;
using System.Collections;
using System.Collections.Generic;

namespace ProductManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Product Manager App");
            Product p1 = new Product("java", "Murach's Java Programming", 59.50);
            Product p2 = new Product {
                Code = "C#",
                Description = "Murach's C# Programming",
                Price = 57.50

            };

            String c = MyConsole.GetString("Code: ");
            String d = MyConsole.GetString("Description: ");
            double p = MyConsole.GetDouble("Price: ");
            Product p3 = new Product(c, d, p);

            Product[] products = { p1, p2, p3 };

            foreach (Product pdt in products)
            {
                Console.WriteLine(pdt);
            }

            Console.WriteLine(products[2]);

            //ArrayList productsList = new ArrayList();
            //type "using System.Collections;" at top

            List<Product> productsList = new List<Product>();
            //System.Collections.Generic;

            productsList.Add(p1);
            productsList.Add(p2);
            productsList.Add(p3);

            Console.WriteLine("ArrayList of products...");
            foreach (Product pdt in productsList)
            {
                Console.WriteLine(pdt);
            }
            
            Product product = productsList[1];
            Console.WriteLine(product);

            Console.WriteLine("Using a Dictionary to store products...");
            Dictionary<string, Product> productsMap = new Dictionary<string, Product>();

            productsMap.Add(p1.Code, p1);
            productsMap.Add(p2.Code, p2);
            productsMap.Add(p3.Code, p3);

            string code = MyConsole.GetString("Enter product code to look up: ");
            Console.WriteLine("Product = " + productsMap[code]);

            /*Console.WriteLine("p1: " + p1);
            Console.WriteLine("p2: " + p2);

            String a = MyConsole.GetString("Enter a string: ");
            Console.WriteLine("String = "+a);

            int i = MyConsole.GetInt("Enter an int: ");
            Console.WriteLine("Int = "+i);

            double d = MyConsole.GetDouble("Enter a double: ");
            Console.WriteLine("Double = "+d);*/

            Console.WriteLine("Goodbye");
        }
    }
}
