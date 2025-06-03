using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Ex1
    {
        // I've put them in the same file due to it being a short exercise, and many others to add yet.
        // Otherwise I'd just make a different file for each class.
        internal static void Exercise()
        {
            Pair<DateTime, string> dateStringPair = new Pair<DateTime, string>(DateTime.Now, "Avui és un bon dia");
            Pair<int, List<string>> intListPair =
                new Pair<int, List<string>>(3, new List<string> { "Primera", "Segona", "Tercera" });

            var (date, message) = dateStringPair.GetValues();
            Console.WriteLine($"Data: {date}, Missatge: {message}");

            var (number, list) = intListPair.GetValues();
            Console.WriteLine($"Número: {number}, Llista: [{string.Join(", ", list)}]");
        }
    }

    class Pair<T1, T2>
    {
        public T1 First { get; set; }
        public T2 Second { get; set; }

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public override string ToString()
        {
            return $"({First}, {Second})";
        }

        public (T1, T2) GetValues()
        {
            return (First, Second);
        }
    }
}
