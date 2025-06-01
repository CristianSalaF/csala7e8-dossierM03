namespace T2Ex14
{
    internal class T2Ex14
    {
        static void Main(string[] args)
        {
            const string TxtIntro = "Introdueix 5 números: ";
            const string TxtCurrentNum = "Numero {0}";
            const string? TxtAllNumbers = "Els números introduïts són:";
            const string TxtSumNumbers = "La suma de tots els números és: {0}";

            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int[] numeros = new int[5];
            int suma = 0;

            Console.WriteLine(TxtIntro);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(TxtCurrentNum, i+1);
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }

            Console.WriteLine(TxtAllNumbers);
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine(TxtSumNumbers, suma);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
