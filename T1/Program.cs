namespace T1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string TxtMenu = "Selecciona un exercici:\n" +
                                   "1. Ex9\n" +
                                   "2. Ex8\n" +
                                   "3. Ex7\n" +
                                   "4. Ex10\n" +
                                   "5. Sortir";
            const string TxtInvalidOption = "Opció no vàlida. Si us plau, selecciona una opció vàlida.";

            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(TxtMenu);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int option))
                {
                    switch (option)
                    {
                        case 1:
                            Ex9.Exercise(args);
                            break;
                        case 2:
                            Ex8.Exercise(args);
                            break;
                        case 3:
                            Ex7.Exercise(args);
                            break;
                        case 4:
                            Ex10.Exercise(args);
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine(TxtInvalidOption);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(TxtInvalidOption);
                }
            }
        }
    }
}
