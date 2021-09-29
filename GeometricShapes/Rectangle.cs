using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricShapes
{
    class Rectangle : Shapes
    {
        public new void Print() // use new when hiding is intended instead of using inherited
        {
            Console.WriteLine($"Perimeter: {Perimeter()}; Area: {Area()}");
        }
         public int Area()
         {
            return side1 * side2;
         }
         public Rectangle(int SideA, int SideB) : base(SideA, SideB, SideA, SideB)
         {
         }
    }
}
