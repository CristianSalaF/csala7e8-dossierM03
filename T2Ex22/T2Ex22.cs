namespace T2Ex22
{
    internal class T2Ex22
    {
        static void Main(string[] args)
        {
            const string TxtGuessPrompt = "Introdueix un número entre 1 i 50: ";
            const string TxtInvalidInput = "Entrada no vàlida. Si us plau, introdueix un número entre 1 i 50.";
            const string TxtHigher = "Més alt!";
            const string TxtLower = "Més baix!";
            const string TxtCorrect = "Has encertat el número {0} en {1} intents!";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Random random = new Random();
            int targetNumber = random.Next(1, 51);
            int userGuess = 0;
            int attempts = 0;
            bool isValidInput = false;

            while (userGuess != targetNumber)
            {
                isValidInput = false;
                while (!isValidInput)
                {
                    Console.Write(TxtGuessPrompt);
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out userGuess) && userGuess >= 1 && userGuess <= 50)
                    {
                        isValidInput = true;
                        attempts++; // Only counts valid attempts
                    }
                    else
                    {
                        Console.WriteLine(TxtInvalidInput);
                    }
                }
                if (userGuess < targetNumber)
                {
                    Console.WriteLine(TxtHigher);
                }
                else if (userGuess > targetNumber)
                {
                    Console.WriteLine(TxtLower);
                }
            }
            Console.WriteLine(TxtCorrect, targetNumber, attempts);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
