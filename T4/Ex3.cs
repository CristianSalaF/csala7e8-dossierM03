using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Ex3
    {
        internal static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            List<int> numbers = new List<int> { 42, 15, 8, 23, 97, 16 };

            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.WriteLine($"Nombres parells: {string.Join(", ", evenNumbers)}");

            List<int> sortedEvenNumbers = evenNumbers.OrderBy(n => n).ToList();
            Console.WriteLine($"Nombres parells ordenats: {string.Join(", ", sortedEvenNumbers)}");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
