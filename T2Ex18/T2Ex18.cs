namespace T2Ex18
{
    internal class T2Ex18
    {
        static void Main(string[] args)
        {
            const string TxtWordPrompt = "Introdueix una paraula: ";
            const string TxtWordsInReverse = "Les paraules en ordre invers són: ";
            const int ArraySize = 5;

            string[] words = new string[ArraySize];
            for (int i = 0; i < ArraySize; i++)
            {
                Console.WriteLine(TxtWordPrompt);
                words[i] = Console.ReadLine();
            }

            Console.WriteLine(TxtWordsInReverse);
            for (int i = ArraySize - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

            Console.WriteLine("Prem qualsevol tecla per sortir...");
            Console.ReadKey();
        }
    }
}
