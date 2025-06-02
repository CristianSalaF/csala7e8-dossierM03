namespace T2
{
    internal class Ex19
    {
        internal static void Exercise(string[] args)
        {
            const string TxtNumberPrompt = "Introdueix un nombre enter positiu: ";
            const string TxtSumOfDigits = "La suma dels dígits del nombre {0} és: {1}";
            const string TxtInvalidError = "Entrada no vàlida. Si us plau, introdueix un enter positiu.";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
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

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
