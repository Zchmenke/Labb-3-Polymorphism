using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_Polymorphism
{
    internal class Rectangle : Geometri
    {
        // Declaring two fields.
        public double length { get; set; }
        public double width { get; set; }

        // setting field values
        public Rectangle()
        {
            length = 5.5;
            width = 10.4;
        }

        // calculation and returns value.
        public override double Area()
        {
            return length * width;
        }
    }

}

