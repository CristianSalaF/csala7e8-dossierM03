namespace T2Ex16
{
    internal class T2Ex16
    {
        static void Main(string[] args)
        {
            const string TxtNumberPrompt = "Introdueix un número entre 1 i 100: ";
            const string TxtInvalidInput = "Entrada no vàlida. Si us plau, introdueix un número entre 1 i 100.";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(TxtNumberPrompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out number) && number >= 1 && number <= 100)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine(TxtInvalidInput);
                }
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
