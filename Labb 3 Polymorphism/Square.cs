using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_Polymorphism
{
    // square class, inherits from Geometri class.
    internal class Square : Geometri
    {
        //declaring a field to use for calculation.
        public double side { get; set; }

        // setting field value
        public Square()
        {
            side = 10;
        }
        // does calculation and returns the value (side * side)
        public override double Area()
        {
            return Math.Pow(side, 2);
        }
    }
}
