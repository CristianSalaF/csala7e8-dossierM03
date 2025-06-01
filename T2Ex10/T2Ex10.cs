using System.Text.RegularExpressions;

namespace T2Ex10
{
    internal class T2Ex10
    {
        static void Main(string[] args)
        {
            const string TxtInputPrompt = "Introdueix un text, ha de tindre 8 nombres seguits d'una lletra: ";
            const string TxtValidText = "El text és vàlid";
            const string TxtInvalidText = "El text no és vàlid. Assegura't que té 8 nombres seguits d'una lletra sense espais.";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            string text = "";

            Console.WriteLine(TxtInputPrompt);
            text = Console.ReadLine();

            if (IsValidText(text))
                Console.WriteLine(TxtValidText);
            else
                Console.WriteLine(TxtInvalidText);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static bool IsValidText(string? text)
        {
            const string TextPattern = @"^\d{8}[a-zA-Z]$";
            return Regex.IsMatch(text, TextPattern);
        }
    }
}
