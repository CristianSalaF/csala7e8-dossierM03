using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace T4
{
    public class Ex7
    {
        public static void Exercise()
        {
            const string TxtStudentsAverage = "Estudiants ordenats per nota mitjana (de major a menor):";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            const string FileName = "estudiants.json";

            string jsonFromFile = "";

            List<Estudiant> estudiants = new List<Estudiant>
            {
                new Estudiant { Id = 1, Nom = "Joan", Cognoms = "Pérez", Edat = 20, NotaMitjana = 8.5 },
                new Estudiant { Id = 2, Nom = "Maria", Cognoms = "García", Edat = 22, NotaMitjana = 9.0 },
                new Estudiant { Id = 3, Nom = "Anna", Cognoms = "López", Edat = 21, NotaMitjana = 7.5 }
            };

            string json = JsonConvert.SerializeObject(estudiants, Formatting.Indented);

            // CSala7e8-DossierRecuperació\T4\bin\Debug\net9.0\files
            if (!Directory.Exists("files"))
            {
                Directory.CreateDirectory("files");
            }
            File.WriteAllText(Path.Combine("files", FileName), json);
            Console.WriteLine($"Llista d'estudiants guardada a {Path.Combine("files", FileName)}");

            jsonFromFile = File.ReadAllText(Path.Combine("files", FileName));
            List<Estudiant> estudiantsFromFile = JsonConvert.DeserializeObject<List<Estudiant>>(jsonFromFile);
            
            var sortedEstudiants = estudiantsFromFile.OrderByDescending(e => e.NotaMitjana).ToList();
            Console.WriteLine(TxtStudentsAverage);
            foreach (var estudiant in sortedEstudiants)
            {
                Console.WriteLine(estudiant);
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }

    public class Estudiant
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Cognoms { get; set; }
        public int Edat { get; set; }
        public double NotaMitjana { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Nom: {Nom}, Cognoms: {Cognoms}, Edat: {Edat}, Nota Mitjana: {NotaMitjana}";
        }
    }
}
