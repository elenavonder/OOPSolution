using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square : Rectangle, IGeometricShape
    {
        public override string WhatAmI()
        {
            return "Square";
        }
        public Square(int side) : base(side, side)
        {

        }
    }
}
