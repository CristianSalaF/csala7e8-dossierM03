using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Ex9
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
            string[] testStrings = {
                "1,2,tres,4,cinc,6",
                "10,20,trenta,40,cinquanta,60,70",
                "abc,def,ghi",
                "1,2,3,4,5",
                "  1  ,  2  ,  hola  ,  3  ",
                "",
                "100,món,200,hello,300"
            };

            foreach (string test in testStrings)
            {
                List<int> result = test.ToIntegerList();
                Console.WriteLine($"Entrada: \"{test}\"");
                Console.WriteLine($"Resultat: [{string.Join(", ", result)}]");
                Console.WriteLine($"Total nombres: {result.Count}\n");
            }


            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }

    public static class Ex8StringExtensions
    {
        public static List<int> ToIntegerList(this string text)
        {
            return text.Split(',')
                .Where(s => int.TryParse(s.Trim(), out _))
                .Select(s => int.Parse(s.Trim()))
                .ToList();
        }
    }
}
