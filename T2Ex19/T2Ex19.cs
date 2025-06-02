namespace T2Ex19
{
    internal class T2Ex19
    {
        static void Main(string[] args)
        {
            const string TxtNumberPrompt = "Introdueix un nombre enter positiu: ";
            const string TxtSumOfDigits = "La suma dels dígits del nombre {0} és: {1}";
            const string TxtInvalidError = "Entrada no vàlida. Si us plau, introdueix un enter positiu.";
            
            int number = 0;
            bool isValidNumber = false;
            while (!isValidNumber)
            {
                Console.WriteLine(TxtNumberPrompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number >= 0)
                {
                    isValidNumber = true;
                }
                else
                {
                    Console.WriteLine(TxtInvalidError);
                }
            }

            int sumOfDigits = 0;
            int tempNumber = number;
            while (tempNumber > 0)
            {
                sumOfDigits += tempNumber % 10;
                tempNumber /= 10;
            }
            Console.WriteLine(TxtSumOfDigits, number, sumOfDigits);

            Console.WriteLine("Prem qualsevol tecla per sortir...");
            Console.ReadKey();
        }
    }
}
