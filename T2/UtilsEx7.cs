using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class UtilsEx7
    {
        public static int CalculateRectangleArea(int width, int height)
        {
            return width * height;
        }

        public static bool IsLeapYear(int year)
        {
            // A year is a leap year if it is divisible by 4, except for end-of-century years.
            // However, those end-of-century years are not leap years unless they are divisible by 400.
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}