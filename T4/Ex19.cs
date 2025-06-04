using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4.Ex19Classes;

namespace T4
{
    public class Ex19
    {
        public static void Exercise()
        {
            const string TxtCircleArea = "L'àrea del cercle és: ";
            const string TxtRectangleArea = "L'àrea del rectangle és: ";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            Circle circle = new Circle { Radius = 5 };
            Rectangle rectangle = new Rectangle { Width = 4, Height = 6 };
            try
            {
                Console.WriteLine(TxtCircleArea + circle.GetArea());
                Console.WriteLine(TxtRectangleArea + rectangle.GetArea());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
