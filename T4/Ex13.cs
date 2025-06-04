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
            const string TxtProductList = "Product List:";
            const string TxtExpensiveProductList = "\nExpensive Products (Price > 50):";

            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            List<Product> products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 999.99m },
                new Product { Name = "Smartphone", Price = 499.99m },
                new Product { Name = "Tablet", Price = 299.99m }
            };
            products.Add(new Product { Name = "Phone Case", Price = 19.99m });

            Console.WriteLine(TxtProductList);
            foreach (var product in products)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

            var expensiveProducts = products.Where(p => p.Price > 50).ToList();
            Console.WriteLine(TxtExpensiveProductList);
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
