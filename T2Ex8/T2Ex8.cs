namespace T2Ex8
{
    internal class T2Ex8
    {
        static void Main(string[] args)
        {
            const string TxtNumber1 = "Introdueix el primer nombre: ";
            const string TxtNumber2 = "Introdueix el segon nombre: ";

            const string TxtResult = "El resultat de la divisió és: {0}";
            const string TxtError = "S'ha produït un error: {0}";
            const string TxtInvalidFormat = "El format introduït no és vàlid. Si us plau, introdueix un nombre enter.";
            const string noEsPotDividirEntreZero = "No es pot dividir entre zero.";

            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            try
            {
                Console.Write(TxtNumber1);
                int num1 = int.Parse(Console.ReadLine());
                Console.Write(TxtNumber2);
                int num2 = int.Parse(Console.ReadLine());
                if (num2 == 0)
                {
                    throw new DivideByZeroException(noEsPotDividirEntreZero);
                }

                float result = (float)num1 / num2;
                Console.WriteLine(TxtResult, result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(TxtError, TxtInvalidFormat);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(TxtError, ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(TxtError, ex.Message);
            }
            finally
            {
                Console.WriteLine(TxtPressToExit);
                Console.ReadKey();
            }
        }
    }
}
