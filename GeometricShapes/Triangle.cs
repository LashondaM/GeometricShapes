using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Triangle
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }

        public double Area()
        {
            return side3 * side2 * 0.5;
        }

        public  int Perimeter()
        {
            return side1 + side2 + side3;
        }
    }
}
