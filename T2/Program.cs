namespace T2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu for each of the T2 Exercises
            const string TxtMenu = "Selecciona un exercici:\n" +
                                   "1. Ex5\n" +
                                   "2. Ex6\n" +
                                   "3. Ex7\n" +
                                   "4. Ex8\n" +
                                   "5. Ex9\n" +
                                   "6. Ex10\n" +
                                   "7. Ex11\n" +
                                   "8. Ex12\n" +
                                   "9. Ex13\n" +
                                   "10. Ex14\n" +
                                   "11. Ex15\n" +
                                   "12. Ex16\n" + 
                                   "13. Ex17\n" +
                                   "14. Ex18\n" +
                                   "15. Ex19\n" +
                                   "16. Ex20\n" +
                                   "17. Ex21\n" +
                                   "18. Ex22\n" +
                                   "0. Sortir del programa";
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
                            Ex5.Exercise(args);
                            break;
                        case 2:
                            Ex6.Exercise(args);
                            break;
                        case 3:
                            Ex7.Exercise(args);
                            break;
                        case 4:
                            Ex8.Exercise(args);
                            break;
                        case 5:
                            Ex9.Exercise(args);
                            break;
                        case 6:
                            Ex10.Exercise(args);
                            break;
                        case 7:
                            Ex11.Exercise(args);
                            break;
                        case 8:
                            Ex12.Exercise(args);
                            break;
                        case 9:
                            Ex13.Exercise(args);
                            break;
                        case 10:
                            Ex14.Exercise(args);
                            break;
                        case 11:
                            Ex15.Exercise(args);
                            break;
                        case 12:
                            Ex16.Exercise(args);
                            break;
                        case 13:
                            Ex17.Exercise(args);
                            break;
                        case 14:
                            Ex18.Exercise(args);
                            break;
                        case 15:
                            Ex19.Exercise(args);
                            break;
                        case 16:
                            Ex20.Exercise(args);
                            break;
                        case 17:
                            Ex21.Exercise(args);
                            break;
                        case 18:
                            Ex22.Exercise(args);
                            break;
                        case 0:
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
