using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var q1 = new Shapes(3, 11, 8, 6);
            //{
            //    side1 = 3,
            //    side2 = 11,
            //    side3 = 8,
            //    side4 = 6
            //};
            //Console.WriteLine($"Perimeter is {q1.Perimeter()}");
            q1.Print();

            var r1 = new Rectangle(3, 5);
            //Console.WriteLine($"Perimeter is {r1.Perimeter()}");
            //Console.WriteLine($"Area is {r1.Area()}");
            r1.Print();

            var r2 = new Rectangle(3, 7);
            r2.Print();


            var sq1 = new Sqr(3);
            //{
            //    side1 = 3, side2 = 3, side3 = 3, side4 = 3
            //};
            sq1.Print();

            var sq2 = new Sqr(4);
            sq2.Print();

            var tri = new Triangle()
            {
                side1 = 19,
                side2 = 19,
                side3 = 38
            };
            Console.WriteLine($"Area is {tri.Area()}");
            Console.WriteLine($"Perimeter is {tri.Perimeter()}");
        }

    }
}
