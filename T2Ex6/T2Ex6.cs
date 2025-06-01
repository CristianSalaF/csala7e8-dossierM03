namespace T2Ex6
{
    internal class T2Ex6
    {
        static void Main(string[] args)
        {
            const string TxtIntro = "Introdueix 10 números enters: ";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
            int[] numbers = new int[10];
            float avg = 0f;
            int evenNums = 0;

            Console.WriteLine(TxtIntro);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            avg = CalculateAverage(numbers);
            evenNums = CountEvenNumbers(numbers);

            Console.WriteLine($"La mitjana dels números és: {avg}");
            Console.WriteLine($"Hi ha {evenNums} números parells i {numbers.Length - evenNums} números senars.");
            
            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static int CountEvenNumbers(int[] numbers)
        {
            int count = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        private static float CalculateAverage(int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return (float)sum / numbers.Length;
        }
    }
}
