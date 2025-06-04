using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4.Ex13Classes;

namespace T4
{
    public class Ex13
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 999.99m },
                new Product { Name = "Smartphone", Price = 499.99m },
                new Product { Name = "Tablet", Price = 299.99m }
            };
            products.Add(new Product { Name = "Smartwatch", Price = 199.99m });

            Console.WriteLine("Product List:");
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price:C}");
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
