using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Ex11Classes
{
    class Car : IVehicle
    {
        const string TxtStartingEngine = "Starting car engine...";
        const string TxtStoppingEngine = "Stopping car engine...";

        public void StartEngine()
        {
            Console.WriteLine(TxtStartingEngine);
        }

        public void StopEngine()
        {
            Console.WriteLine(TxtStoppingEngine);
        }
    }
}
