using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Quad//Quadrillateral
    {
        protected int Side1 { get; set; }
        protected int Side2 { get; set; }
        protected int Side3 { get; set; }
        protected int Side4 { get; set; }

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
