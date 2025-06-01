using System.Text.RegularExpressions;

namespace T2Ex9
{
    internal class T2Ex9
    {
        static void Main(string[] args)
        {
            const string TxtPasswordPrompt = "Introdueix una contrasenya: ";
            const string TxtValidPassword = "La contrasenya és vàlida";
            const string TxtInvalidPassword = "La contrasenya no és vàlida. " +
                                              "Assegura't que té entre 8 i 12 caràcters, inclou almenys una majúscula, " +
                                              "una minúscula i un número, i no conté espais.";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            string password = "";

            Console.WriteLine(TxtPasswordPrompt);
            password = Console.ReadLine();

            if (IsValidPassword(password))
                Console.WriteLine(TxtValidPassword);
            else
                Console.WriteLine(TxtInvalidPassword);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static bool IsValidPassword(string? password)
        {
            const string PasswordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[^\s]{8,12}$";
            return Regex.IsMatch(password, PasswordPattern);
        }
    }
}
