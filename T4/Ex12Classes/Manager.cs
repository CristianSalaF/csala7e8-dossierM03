using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Ex12Classes
{
    class Manager : Employee
    {
        public string Department { get; set; }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Id: {Id}, Name: {Name}, Department: {Department}");
        }
    }
}
