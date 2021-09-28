using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Shapes()
            {
                side1 = 3,
                side2 = 11,
                side3 = 8,
                side4 = 6
            };
            Console.WriteLine($"Perimeter is {q1.Perimeter()}");

            var r1 = new Rectangle()
            {
                side1 = 4,
                side2 = 6
            };
            Console.WriteLine($"Perimeter is {r1.Perimeter()}");
            Console.WriteLine($"Area is {r1.Area()}");

            var sq1 = new Sqr()
            {
                side1 = 5
            };
            Console.WriteLine($"Perimeter is {sq1.Perimeter()}");
            Console.WriteLine($"Area is {sq1.Area()}");
        }

    }
}
