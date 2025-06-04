using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Ex19Classes
{
    public class Circle : Shape
    {
        const string TxtParameterError = "Radius must be non-negative.";
        public float Radius { get; set; }

        public override float GetArea()
        {
            if (Radius < 0)
            {
                throw new ArgumentException(TxtParameterError);
            }
            return (float)(Math.PI * (Radius * Radius));
        }
    }
}
