using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Quad 
    {
        public int Side1 { get; private set; }
        public int Side2 { get; private set; }
        public int Side3 { get; private set; }
        public int Side4 { get; private set; }

        public virtual string WhatAmI()
        {
            return "Quadrillateral";
        }
        public int Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }

        public Quad(int s1, int s2, int s3, int s4)
        {
            this.Side1 = s1;
            this.Side2 = s2;
            this.Side3 = s3;
            this.Side4 = s4;
        }

        public Quad()
        {

        }
    }
}
