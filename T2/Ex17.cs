namespace T2
{
    internal class Ex17
    {
        const string TxtNumberPrompt = "Introdueix un nombre enter positiu: ";
        const string TxtSearchPrompt = "Introdueix un nombre a buscar: ";
        const string TxtFound = "El nombre {0} es troba a la posició {1} de l'array.";
        const string TxtNotFound = "El nombre {0} no es troba a l'array.";
        const string TxtInvalidError = "Entrada no vàlida. Si us plau, introdueix un enter positiu.";
        const int ArraySize = 10;

        internal static void Exercise(string[] args)
        {
            int[] numbers = new int[ArraySize];
            
            UserNumberArrayInput(numbers);
            SearchUserNumbers(numbers);

            Console.WriteLine("Prem qualsevol tecla per sortir...");
            Console.ReadKey();
        }

        private static void UserNumberArrayInput(int[] numbers)
        {
            for (int i = 0; i < ArraySize; i++)
            {
                int number;
                bool isValidNumber = false;
                while (!isValidNumber)
                {
                    Console.WriteLine(TxtNumberPrompt);
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out number) && number > 0)
                    {
                        numbers[i] = number;
                        isValidNumber = true;
                    }
                    else
                    {
                        Console.WriteLine(TxtInvalidError);
                    }
                }
            }
        }

        private static void SearchUserNumbers(int[] numbers)
        {
            bool isValidNumber = false;
            int searchNumber = 0;
            
            while (!isValidNumber)
            {
                Console.WriteLine(TxtSearchPrompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out searchNumber) && searchNumber > 0)
                {
                    isValidNumber = true;
                }
                else
                {
                    Console.WriteLine(TxtInvalidError);
                }
            }

            bool found = false;
            for (int i = 0; i < ArraySize && !found; i++)
            {
                if (numbers[i] == searchNumber)
                {
                    Console.WriteLine(TxtFound, searchNumber, i);
                    found = true;
                }
            }
            if (!found) Console.WriteLine(TxtNotFound, searchNumber);
        }
    }
}
