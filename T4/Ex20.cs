using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex20
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            List<string> words = new List<string>
            {
                "programació",
                "codi",
                "exercici",
                "llista",
                "funció",
                "llenguatge",
                "desenvolupament",
                "aplicació",
                "algorisme"
            };

            List<string> longestWords = words
                .OrderByDescending(word => word.Length)
                .Take(3)
                .ToList();

            Console.WriteLine("Les 3 paraules més llargues són:");
            foreach (var word in longestWords)
                Console.WriteLine($"Paraula: {word}, Longitud: {word.Length}");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
