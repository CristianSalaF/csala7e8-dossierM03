using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Ex8
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            List<Persona> persones = new List<Persona>
            {
                new Persona { Nom = "Joan", Edat = 30, Ciutat = "Barcelona" },
                new Persona { Nom = "Maria", Edat = 22, Ciutat = "Girona" },
                new Persona { Nom = "Anna", Edat = 28, Ciutat = "Barcelona" },
                new Persona { Nom = "Pere", Edat = 35, Ciutat = "Girona" },
                new Persona { Nom = "Laura", Edat = 20, Ciutat = "Madrid" },
                new Persona { Nom = "Marc", Edat = 27, Ciutat = "Barcelona" }
            };

            PrintPersonaOlderThan25(persones);
            PrintPersonaBarcelonaOrGirona(persones);
            PrintYoungestByCity(persones);
            PrintCountByCity(persones);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static void PrintPersonaOlderThan25(List<Persona> persones)
        {
            const string TxtPersonaOver25 = "Persones majors de 25 anys:";

            var majorsDe25 = persones.Where(p => p.Edat > 25).ToList();
            Console.WriteLine(TxtPersonaOver25);
            foreach (var persona in majorsDe25)
            {
                Console.WriteLine($"{persona.Nom}, {persona.Edat} anys, {persona.Ciutat}");
            }
        }

        private static void PrintPersonaBarcelonaOrGirona(List<Persona> persones)
        {
            const string TxtPersonaBcnGir = "\nPersones que viuen a Barcelona o Girona:";

            var aBarcelonaOGirona = persones.Where(p => p.Ciutat == "Barcelona" || p.Ciutat == "Girona").ToList();
            Console.WriteLine(TxtPersonaBcnGir);
            foreach (var persona in aBarcelonaOGirona)
            {
                Console.WriteLine($"{persona.Nom}, {persona.Edat} anys, {persona.Ciutat}");
            }
        }

        private static void PrintYoungestByCity(List<Persona> persones)
        {
            const string TxtPersonaYoungest = "\nPersona més jove de cada ciutat:";

            var mesJovePerCiutat = persones.GroupBy(p => p.Ciutat)
                .Select(g => g.OrderBy(p => p.Edat).First())
                .ToList();
            Console.WriteLine(TxtPersonaYoungest);
            foreach (var persona in mesJovePerCiutat)
            {
                Console.WriteLine($"{persona.Nom}, {persona.Edat} anys, {persona.Ciutat}");
            }
        }

        private static void PrintCountByCity(List<Persona> persones)
        {
            const string TxtPersonaCountByCity = "\nComptador de persones per ciutat:";

            var comptadorPerCiutat = persones.GroupBy(p => p.Ciutat)
                .Select(g => new { Ciutat = g.Key, Comptador = g.Count() })
                .ToList();
            Console.WriteLine(TxtPersonaCountByCity);
            foreach (var item in comptadorPerCiutat)
            {
                Console.WriteLine($"Ciutat: {item.Ciutat}, Comptador: {item.Comptador}");
            }
        }

        public class Persona
        {
            public string Nom { get; set; }
            public int Edat { get; set; }
            public string Ciutat { get; set; }
        }
    }

}
