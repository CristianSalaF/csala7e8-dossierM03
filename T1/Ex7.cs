namespace T1
{
    internal class Ex7
    {
        internal static void Exercise(string[] args)
        {
            const string TxtNumberPrompt = "Introdueix un nombre enter positiu: ";
            const string TxtDivisors = "Els divisors parells de ";
            const string TxtNumber = "El nombre ";
            const string TxtNoDivisors = "No hi ha divisors parells per al nombre ";
            const string TxtInvalidError = $"Entrada no vàlida. Si us plau, introdueix un enter positiu.";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int number = 0;
            bool isValidNumber = false;

            while (!isValidNumber )
            {
                Console.WriteLine(TxtNumberPrompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out number) && number > 0)
                {
                    isValidNumber = true;
                }
                else
                {
                    Console.WriteLine(TxtInvalidError);
                }
            }

            Console.WriteLine($"{TxtDivisors}{number} són:");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0 && i % 2 == 0)
                {
                    Console.WriteLine($"{TxtNumber}{i}");
                }
            }

            if (number % 2 != 0)
            {
                Console.WriteLine($"{TxtNoDivisors}{number}.");
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();

        }
    }
}
