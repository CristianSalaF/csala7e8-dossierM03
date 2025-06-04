using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4.Ex11Classes;

namespace T4
{
    public class Ex11
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            IVehicle car = new Car();
            IVehicle bike = new Motorbike();

            car.StartEngine();
            bike.StartEngine();

            car.StopEngine();
            bike.StopEngine();

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
