using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex15
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Values<int> intValues = new Values<int> { First = 1, Second = 2 };
            Values<string> stringValues = new Values<string> { First = "Hola", Second = "Món" };

            Console.WriteLine($"Abans de l'intercanvi: First = {intValues.First}, Second = {intValues.Second}");
            intValues.SwapProperties();
            Console.WriteLine($"Després de l'intercanvi: First = {intValues.First}, Second = {intValues.Second}");

            Console.WriteLine($"Abans de l'intercanvi: First = {stringValues.First}, Second = {stringValues.Second}");
            stringValues.SwapProperties();
            Console.WriteLine($"Després de l'intercanvi: First = {stringValues.First}, Second = {stringValues.Second}");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }

    public class Values<T>
    {
        public T First { get; set; }
        public T Second { get; set; }
        public void SwapProperties()
        {
            (First, Second) = (Second, First);
        }
    }
}
