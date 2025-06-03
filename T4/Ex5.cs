using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Ex5
    {
        internal static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            MathOperation suma = (a, b) => a + b;
            MathOperation resta = (a, b) => a - b;
            MathOperation multiplicacio = (a, b) => a * b;
            MathOperation divisio = (a, b) => b != 0 ? a / b : double.NaN; // Evita divisió per zero

            double num1 = 10.0;
            double num2 = 5.0;
            double resultatSuma = ExecutarOperacio(num1, num2, suma);
            double resultatResta = ExecutarOperacio(num1, num2, resta);
            double resultatMultiplicacio = ExecutarOperacio(num1, num2, multiplicacio);
            double resultatDivisio = ExecutarOperacio(num1, num2, divisio);

            Console.WriteLine($"Suma: {num1} + {num2} = {resultatSuma}");
            Console.WriteLine($"Resta: {num1} - {num2} = {resultatResta}");
            Console.WriteLine($"Multiplicació: {num1} * {num2} = {resultatMultiplicacio}");
            if (resultatDivisio != double.NaN)
            {
                Console.WriteLine($"Divisió: {num1} / {num2} = {resultatDivisio}");
            }
            else
            {
                Console.WriteLine("Divisió per zero no és vàlida.");
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        public delegate double MathOperation(double a, double b);

        public static double ExecutarOperacio(double a, double b, MathOperation operacio)
        {
            return operacio(a, b);
        }
    }
}
