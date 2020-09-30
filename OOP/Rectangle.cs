using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangle : Quad
    {
        public Rectangle(int LongSide, int ShortSide)
        {
            this.Side1 = LongSide;
            this.Side2 = ShortSide;
            this.Side3 = LongSide;
            this.Side4 = ShortSide;
        }
        public Rectangle()
        {

        }
    }
}
