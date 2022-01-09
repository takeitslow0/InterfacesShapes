using InterfacesShapes.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesShapes.Models
{
    class RightTriangle : IShapeWithAngles
    {
        public double Width { get ; set ; }
        public double Height { get ; set ; }

        public double CalculateArea()
        {
            return (Width * Height) / 2;
        }

        public double CalculateCircumference()
        {
            return Math.Sqrt((Width * Width) + (Height * Height)) + Width + Height;
        }
    }
}
