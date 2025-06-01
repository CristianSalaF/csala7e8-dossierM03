using System.Globalization;
using System.Text.RegularExpressions;

namespace T2Ex11
{
    internal class T2Ex11
    {
        static void Main(string[] args)
        {
            const string TxtDateInput = "Introdueix una data (dd/MM/yyyy): ";
            const string TxtInvalidDateFormat = "Format incorrecte. Usa dd/MM/yyyy.";
            const string TxtValidDate = "La data és vàlida.";
            const string TxtInvalidDate = "La data no és vàlida.";
            const string DateFormat = "dd/MM/yyyy";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Console.Write(TxtDateInput);
            string userDate = Console.ReadLine();

            string regexData = @"^\d{2}/\d{2}/\d{4}$";

            if (!Regex.IsMatch(userDate, regexData))
            {
                Console.WriteLine(TxtInvalidDateFormat);
                return;
            }

            if (DateTime.TryParseExact(userDate, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
            {
                Console.WriteLine(TxtValidDate);
                Console.WriteLine($"Cau en un {data.ToString("dddd", CultureInfo.InvariantCulture)}.");
            }
            else
            {
                Console.WriteLine(TxtInvalidDate);
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
