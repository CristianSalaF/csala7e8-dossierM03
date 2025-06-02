namespace T2
{
    internal class Ex5
    {
        internal static void Exercise(string[] args)
        {
            const string TxtIntro = "Introdueix un número: ";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int num = 0;

            Console.WriteLine(TxtIntro);
            num = int.Parse(Console.ReadLine());
            bool isPrime = false;

            int resultIterative = CalcFactorialIterative(num);
            int resultRecursive = CalcFactorialRecursive(num);
            isPrime = IsPrimeNumber(num);

            Console.WriteLine("El factorial de {0} és: {1} (iteratiu)", num, resultIterative);
            Console.WriteLine("El factorial de {0} és: {1} (recursiu)", num, resultRecursive);
            Console.WriteLine("El número {0} és {1}primer", num, isPrime ? "" : "no ");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static int CalcFactorialIterative(int num)
        {
            int result =1;

            for (int i = 2; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        private static int CalcFactorialRecursive(int num)
        {
            return num <= 1 ? 1 : num * CalcFactorialRecursive(num - 1);
        }

        static bool IsPrimeNumber(int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
