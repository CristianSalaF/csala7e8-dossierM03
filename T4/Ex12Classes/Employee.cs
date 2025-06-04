using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Ex12Classes
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee Id: {Id}, Name: {Name}");
        }
    }
}
