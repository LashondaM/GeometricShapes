using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rectangle
    {
        public int side1 { get; set; }
        public int side2 { get; set; }

        public int Perimeter()
        {
            return 2 * (side1 + side2);
        }

        public int Area()
        {
            return side1 * side2;
        }
    }
}
