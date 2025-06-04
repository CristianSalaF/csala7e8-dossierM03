using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4.Ex12Classes;

namespace T4
{
    public class Ex12
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
            Employee emp = new Employee
            {
                Id = 0,
                Name = "John Doe"
            };

            Employee mgr = new Manager
            {
                Id = 2,
                Name = "Bob",
                Department = "IT"
            };

            Employee dev = new Developer
            {
                Id = 1,
                Name = "Alice",
                CurrentProject = "Project A",
                ProgrammingLanguage = "C#"
            };

            emp.DisplayInfo();
            mgr.DisplayInfo();
            dev.DisplayInfo();

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
