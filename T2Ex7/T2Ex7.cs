namespace T2Ex7
{
    internal class T2Ex7
    {
        static void Main(string[] args)
        {
            // 7. Implementa en C# programa que mostri un menú amb opcions:
            //  a) Calcular àrea d’un rectangle
            //  b) Mostrar si un any és de traspàs
            //  c) Sortir del programa
            // S’han d’implementar els mètodes estàtics i invocar-los des del programa principal

            const string TxtMenu = "Menú:\n" +
                                   "a) Calcular àrea d’un rectangle\n" +
                                   "b) Mostrar si un any és de traspàs\n" +
                                   "c) Sortir del programa\n" +
                                   "Introdueix la teva opció: ";

            const string TxtRectangleWidth = "Introdueix l'amplada del rectangle: ";
            const string TxtRectangleHeight = "Introdueix l'altura del rectangle: ";
            const string TxtAreaResult = "L'àrea del rectangle és: ";

            const string TxtYearInput = "Introdueix un any: ";

            const string? TxtInvalidOption = "Opció no vàlida. Si us plau, intenta-ho de nou.";
            const string TxtExit = "Sortint del programa...";

            int opc = 0;

            do
            {
                Console.WriteLine(TxtMenu);
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        
                        Console.Write(TxtRectangleWidth);
                        int width = int.Parse(Console.ReadLine());
                        Console.Write(TxtRectangleHeight);
                        int height = int.Parse(Console.ReadLine());
                        int area = UtilsEx7.CalculateRectangleArea(width, height);
                        Console.WriteLine($"{TxtAreaResult}{area}");
                        break;
                    case 2:
                        Console.Write(TxtYearInput);
                        int year = int.Parse(Console.ReadLine());
                        bool isLeapYear = UtilsEx7.IsLeapYear(year);
                        Console.WriteLine($"L'any {year} {(isLeapYear ? "és de traspàs" : "no és de traspàs")}");
                        break;
                    case 0:
                        Console.WriteLine(TxtExit);
                        break;
                    default:
                        Console.WriteLine(TxtInvalidOption);
                        break;
                }
            } while (opc != 0);

        }
    }
}
