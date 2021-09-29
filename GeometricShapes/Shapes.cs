using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    //this is for the Quadrilteral
    class Shapes
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int side4 { get; set; }

        public void Print()
        {
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }

        public int Perimeter()
        {
            return side1 + side2 + side3 + side4;
        }

        public Shapes(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side2 = side3;
            this.side4 = side4;
        }
    }
}
