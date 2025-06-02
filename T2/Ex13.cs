namespace T2
{
    internal class Ex13
    {
        internal static void Exercise(string[] args)
        {
            const string TxtNumberInput = "Introdueix un número per veure la seva taula de multiplicar: ";
            const string TxtTable = "Taula de multiplicar del ";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Console.Write(TxtNumberInput);
            int userNumber = 0;

            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.Write(TxtNumberInput);
            }

            Console.WriteLine($"{TxtTable}{userNumber}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{userNumber} x {i} = {userNumber * i}");
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
