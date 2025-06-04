using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex14
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
            string cadena1 = "hola món";
            string cadena2 = "això és una prova";
            string cadena3 = "C# és genial, però millor a Unity";
            string cadena4 = "Sabies que ara Apple vol comprar el motor de Unity? Espero que no! :(";

            Console.WriteLine($"Original: '{cadena1}' -> Resultat: '{cadena1.ToUpperWithoutSpaces()}'");
            Console.WriteLine($"Original: '{cadena2}' -> Resultat: '{cadena2.ToUpperWithoutSpaces()}'");
            Console.WriteLine($"Original: '{cadena3}' -> Resultat: '{cadena3.ToUpperWithoutSpaces()}'");
            Console.WriteLine($"Original: '{cadena4}' -> Resultat: '{cadena4.ToUpperWithoutSpaces()}'");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }

    public static class StringExtensions
    {
        public static string ToUpperWithoutSpaces(this string input)
        {
            return input.ToUpper().Replace(" ", "");
        }
    }
}
