namespace T2Ex12
{
    internal class T2Ex12
    {
        static void Main(string[] args)
        {
            const string TxtNumberInput = "Introdueix un número: ";
            const string TxtPositive = "El número és positiu.";
            const string TxtNegative = "El número és negatiu.";
            const string TxtZero = "El número és zero.";
            const string TxtEven = "El número és parell.";
            const string TxtOdd = "El número és senar.";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Console.Write(TxtNumberInput);
            int userNumber;
            while (!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.Write(TxtNumberInput);
            }

            Console.WriteLine(userNumber > 0 ? TxtPositive : userNumber < 0 ? TxtNegative : TxtZero);
            Console.WriteLine(userNumber % 2 == 0 ? TxtEven : TxtOdd);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
