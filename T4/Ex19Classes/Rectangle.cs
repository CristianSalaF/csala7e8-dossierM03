using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Ex19Classes
{
    public class Rectangle : Shape
    {
        const string TxtParameterError = "Width and Height must be non-negative.";

        public float Width { get; set; }
        public float Height { get; set; }

        public override float GetArea()
        {
            if (Width < 0 || Height < 0)
            {
                throw new ArgumentException(TxtParameterError);
            }
            return Width * Height;
        }
    }
}
