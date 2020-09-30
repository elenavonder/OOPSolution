using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var rect1 = new Rectangle(5, 3);
            Console.WriteLine($"The Perimeter of the Rectangle is {rect1.Perimeter()}");

            var quad1 = new Quad()
            {
                Side1 = 3,
                Side2 = 4,
                Side3 = 5,
                Side4 = 6
            };
            Console.WriteLine($"The Perimeter of the Quadrilateral is {quad1.Perimeter()}");
        }
    }
}
