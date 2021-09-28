using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Sqr
    {
        public int side1 { get; set; }

        public int Perimeter()
        {
            return side1 * 4;
        }

        public int Area()
        {
            return side1 * side1;
        }
    }
}
