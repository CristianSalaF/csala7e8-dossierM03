using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex16
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
            Dictionary<string, int> productUnitSales = new Dictionary<string, int>
            {
                { "Producte A", 150 },
                { "Producte B", 200 },
                { "Producte C", 300 },
                { "Producte D", 100 }
            };

            Console.WriteLine("Vendes de productes:");
            foreach (var product in productUnitSales)
                Console.WriteLine($"{product.Key}: {product.Value} unitats venudes");

            productUnitSales["Producte E"] = 250;
            productUnitSales["Producte A"] += 50;
            Console.WriteLine("\nDesprés d'afegir i actualitzar:");
            foreach (var product in productUnitSales) 
                Console.WriteLine($"{product.Key}: {product.Value} unitats venudes");
            

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
