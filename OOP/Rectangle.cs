using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangle : Quad, IGeometricShape
    {
        public override string WhatAmI()
        {
            return "Rectangle";
        }

        public int Area()
        {
            return Side1 * Side2;
        }
        public Rectangle(int LongSide, int ShortSide) : base (LongSide, ShortSide, LongSide, ShortSide)
        {
            //this.Side1 = LongSide;
            //this.Side2 = ShortSide;
            //this.Side3 = LongSide;
            //this.Side4 = ShortSide;
        }
        public Rectangle()
        {

        }
    }
}
