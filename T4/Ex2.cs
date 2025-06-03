using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex2
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Hashtable hashtable = new Hashtable
            {
                { "nom", "Joan" },
                { "edat", 30 },
                { "ciutat", "Barcelona" },
                { "programador", true }
            };

            PrintHashtable(hashtable);

            if (!hashtable.ContainsKey("professió")) 
                hashtable["professió"] = "Desenvolupador";

            if (hashtable.ContainsKey("programador")) 
                hashtable.Remove("programador");

            Console.WriteLine("\nHashtable actualitzat:");
            PrintHashtable(hashtable);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static void PrintHashtable(Hashtable hashtable)
        {
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"Clau: {entry.Key}, Valor: {entry.Value}");
            }
        }
    }
}
