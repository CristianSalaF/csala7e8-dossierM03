namespace T4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Menu for each of the T2 Exercises
            const string TxtMenu = "Selecciona un exercici:\n" +
                                   "1. Ex1\n" +
                                   "2. Ex2\n" +
                                   "3. Ex3\n" +
                                   "4. Ex4\n" +
                                   "5. Ex5\n" +
                                   "6. Ex6\n" +
                                   "7. Ex7\n" +
                                   "8. Ex8\n" +
                                   "9. Ex9\n" +
                                   "11. Ex11\n" +
                                   "12. Ex12\n" + 
                                   "13. Ex13\n" +
                                   "14. Ex14\n" +
                                   "15. Ex15\n" +
                                   "16. Ex16\n" +
                                   "17. Ex17\n" +
                                   "18. Ex18\n" +
                                   "19. Ex19\n" +
                                   "20. Ex20\n" +
                                   "21. Ex21\n" +
                                   "22. Ex22\n" +
                                   "23. Ex23\n" +
                                   "24. Ex24\n" +
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
                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            Ex1.Exercise();
                            break;
                        case 2:
                            Ex2.Exercise();
                            break;
                        case 3:
                            Ex3.Exercise();
                            break;
                        case 4:
                            Ex4.Exercise();
                            break;
                        case 5:
                            Ex5.Exercise();
                            break;
                        case 6:
                            Ex6.Exercise();
                            break;
                        case 7:
                            Ex7.Exercise();
                            break;
                        case 8:
                            Ex8.Exercise();
                            break;
                        case 9:
                            Ex9.Exercise();
                            break;
                        case 11:
                            Ex11.Exercise();
                            break;
                        case 12:
                            Ex12.Exercise();
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
