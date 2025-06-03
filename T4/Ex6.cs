using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    public class Ex6
    {
        public static void Exercise()
        {
            const string TxtBirthDate = "Introdueix la teva data de naixement (DD/MM/YYYY): ";
            const string TxtErrorDateFormat = "Format de data incorrecte. Utilitza DD/MM/YYYY.";

            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            
            Console.Write(TxtBirthDate);
        
            if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, 
                    System.Globalization.DateTimeStyles.None, out DateTime birthDate))
            {
                DateTime today = DateTime.Today;
            
                int years = today.Year - birthDate.Year;
                int months = today.Month - birthDate.Month;
                int days = today.Day - birthDate.Day;
            
                if (days < 0)
                {
                    months--;
                    days += DateTime.DaysInMonth(today.AddMonths(-1).Year, today.AddMonths(-1).Month);
                }
                if (months < 0)
                {
                    years--;
                    months += 12;
                }
            
                string dayOfWeek = birthDate.ToString("dddd", new System.Globalization.CultureInfo("ca-ES"));
            
                DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
                if (nextBirthday < today)
                    nextBirthday = nextBirthday.AddYears(1);
            
                int daysToNext = (nextBirthday - today).Days;
            
                Console.WriteLine($"\nTens {years} anys, {months} mesos i {days} dies.");
                Console.WriteLine($"Vas néixer un {dayOfWeek}.");
                Console.WriteLine($"Falten {daysToNext} dies pel teu proper aniversari.");
            }
            else
            {
                Console.WriteLine(TxtErrorDateFormat);
            }

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }
    }
}
