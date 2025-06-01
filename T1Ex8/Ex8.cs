namespace T1Ex8
{
    internal class Ex8
    {
        static void Main(string[] args)
        {
            const string TxtAmount = "Introdueix la quantitat de nombres";
            const string TxtNumber = "Introdueix un nombre: ";

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

            Console.ReadKey();
        }
    }
}
