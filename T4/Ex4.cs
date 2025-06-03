using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Ex4
    {
        internal static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            List<Producte> products = new List<Producte>
            {
                new Producte { Nom = "Portàtil", Preu = 800.00m, Categoria = "Electrònica" },
                new Producte { Nom = "Telèfon mòbil", Preu = 600.00m, Categoria = "Electrònica" },
                new Producte { Nom = "Cafetera", Preu = 50.00m, Categoria = "Llar" },
                new Producte { Nom = "Taula", Preu = 150.00m, Categoria = "Mobles" },
                new Producte { Nom = "Cadira", Preu = 75.00m, Categoria = "Mobles" }
            };

            var groupedProducts = products.GroupBy(p => p.Categoria).ToList();
            foreach (var group in groupedProducts)
            {
                Console.WriteLine($"Categoria: {group.Key}");
                foreach (var product in group)
                {
                    Console.WriteLine($"  Nom: {product.Nom}, Preu: {product.Preu}");
                }
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }

    public class Producte
    {
        public string Nom { get; set; }
        public decimal Preu { get; set; }
        public string Categoria { get; set; }
    }

}
