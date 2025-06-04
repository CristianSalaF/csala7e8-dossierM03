using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T4.Ex17Classes;

namespace T4
{
    public class Ex17
    {
        public static void Exercise()
        {
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";

            List<Student> students = new List<Student>
            {
                new Student { Name = "Alice", Grade = 8.5 },
                new Student { Name = "Bob", Grade = 6.0 },
                new Student { Name = "Charlie", Grade = 7.5 },
                new Student { Name = "David", Grade = 9.0 }
            };

            Console.WriteLine("Estudiants amb nota superior a 7, ordenats per nom:");
            List<Student> filteredStudents = students
                .Where(s => s.Grade > 7)
                .OrderBy(s => s.Name)
                .ToList();
            foreach (var student in filteredStudents)
                Console.WriteLine($"Nom: {student.Name}, Nota: {student.Grade}");

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
