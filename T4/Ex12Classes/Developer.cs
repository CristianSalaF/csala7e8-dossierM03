using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Ex12Classes
{
    class Developer : Employee
    {
        public string CurrentProject { get; set; }
        public string ProgrammingLanguage { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Developer Id: {Id}, Name: {Name}, Current Project: {CurrentProject}, Programming Language: {ProgrammingLanguage}");
        }
    }
}
