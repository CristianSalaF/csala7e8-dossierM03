namespace T2
{
    internal class Ex15
    {
        internal static void Exercise(string[] args)
        {
            const string TxtNumberPrompt = "Introdueix un número per calcular el seu quadrat: ";
            const string TxtResult = "El quadrat de {0} és: {1}";

            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int number = 0;

            Console.WriteLine(TxtNumberPrompt);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Entrada no vàlida. Si us plau, introdueix un número enter.");
            }
            Console.WriteLine(TxtResult, number, CalculateSquare(number));

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        static int CalculateSquare(int num)
        {
            return num * num;
        }
    }
}
