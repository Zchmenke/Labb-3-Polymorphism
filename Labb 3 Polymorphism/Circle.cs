using System;
using System.Collections.Generic;
using System.Text;

namespace Labb_3_Polymorphism
{     

    // Circle class that inherits from Geometri class.
    internal class Circle : Geometri
    {
       // declaring field
        double radius { get; set; }

        // setting field value
        public Circle()
        {
            radius = 7;
        }

        // does calculation and returns value (3.141 * radius squared)
        public override double Area()
        {           
            return 3.141 * Math.Pow(radius, 2);
        }
    }
}
