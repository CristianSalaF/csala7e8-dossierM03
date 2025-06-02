namespace T2Ex21
{
    internal class T2Ex21
    {
        const string TxtCelsiusPrompt = "Introdueix una temperatura en graus Celsius: ";
        const string TxtConversionPrompt = "Vols convertir a Fahrenheit (F) o Kelvin (K)? ";
        const string TxtInvalidInput = "Entrada no vàlida. Si us plau, introdueix una temperatura vàlida.";
        const string TxtFahrenheitResult = "La temperatura en Fahrenheit és: {0}°F";
        const string TxtKelvinResult = "La temperatura en Kelvin és: {0} K";
        const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

        static void Main(string[] args)
        {
            float celsius = 0;
            celsius = GetUserInputCelsius();

            Console.WriteLine(TxtConversionPrompt);
            string conversionChoice = "";

            while (conversionChoice != "F" && conversionChoice != "K")
            {
                conversionChoice = Console.ReadLine()?.ToUpper();
                
                switch (conversionChoice)
                {
                    case "F":
                        float fahrenheit = ((celsius * 9) / 5) + 32;
                        Console.WriteLine(TxtFahrenheitResult, fahrenheit);
                        break;
                    case "K":
                        float kelvin = celsius + 273.15f;
                        Console.WriteLine(TxtKelvinResult, kelvin);
                        break;
                    default:
                        Console.WriteLine(TxtInvalidInput);
                        break;
                }
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static float GetUserInputCelsius()
        {
            float celsius = 0f;
            bool isValidCelsius = false;
            while (!isValidCelsius)
            {
                Console.WriteLine(TxtCelsiusPrompt);
                string input = Console.ReadLine();
                if (float.TryParse(input, out celsius))
                {
                    isValidCelsius = true;
                }
                else
                {
                    Console.WriteLine(TxtInvalidInput);
                }
            }

            return celsius;
        }
    }
}
