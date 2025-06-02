namespace T1
{
    internal class Ex8
    {
        internal static void Exercise(string[] args)
        {
            const string TxtAmount = "Introdueix la quantitat de nombres";
            const string TxtNumber = "Introdueix un nombre: ";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            int amount = 0;
            int sum = 0;
            int num = 0;
            float avg = 0;

            Console.WriteLine(TxtAmount);
            amount = int.Parse(Console.ReadLine() ?? "1");

            for (int cnt = 0; cnt < amount; cnt++)
            {
                Console.WriteLine(TxtNumber);
                num = int.Parse(Console.ReadLine() ?? "1");
                sum += num;
            }

            avg = sum / amount;
            Console.WriteLine("La mitjana dels {0} nombres és: {1}", amount, avg);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
