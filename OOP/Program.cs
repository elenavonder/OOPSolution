using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //composition
            var rectcomp1 = new RectComp(3, 9);
            Console.WriteLine($"The Perimeter of the rectcomp1 is {rectcomp1.Perimeter()}");
            Console.WriteLine($"The Area of the rectcomp1 is {rectcomp1.Area()}");

            Quad fred = new Rectangle();
            Console.WriteLine($"Fred is a {fred.WhatAmI()}"); 

            var sqr1 = new Square(4);
            Console.WriteLine($"The Perimeter of the Square is {sqr1.Perimeter()}");
            Console.WriteLine($"The Area of the Square is {sqr1.Area()}");
            Console.WriteLine($"The sqr1 is a {sqr1.WhatAmI()}");

            var rect1 = new Rectangle(5, 3);
            Console.WriteLine($"The Perimeter of the Rectangle is {rect1.Perimeter()}");
            Console.WriteLine($"The Area of the Rectangle is {rect1.Area()}");
            Console.WriteLine($"The rect1 is a {rect1.WhatAmI()}");

            var quad1 = new Quad(3, 4, 5, 6);
            {
                //Side1 = 3
                //Side2 = 4
                //Side3 = 5
                //Side4 = 6
            }
            Console.WriteLine($"The Perimeter of the Quadrilateral is {quad1.Perimeter()}");
            Console.WriteLine($"The quad1 is a {quad1.WhatAmI()}");

            var collection = new Quad[]
            {
                fred, sqr1, rect1, quad1
            };
            foreach (var geo in collection)
            {
                Console.WriteLine($"Shape is {geo.WhatAmI()}");
                var hello = geo as Rectangle;
                if (hello != null)
                {
                    Console.WriteLine($"The area of Shape {hello.Area()}");
                }
            }

            var geoshapes = new IGeometricShape[]
            {
                new Circle (1), new Circle (2), 
            };
            foreach (var shape in geoshapes)
            {
            Console.WriteLine($"The Perimeter is {shape.Perimeter()} The Area is {shape.Area()}");
            }
        }
    }
}
