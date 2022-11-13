using System;

namespace Labb_3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating objects and calling the method with a Console.WriteLite!

            Geometri rectangle = new Rectangle();
            Console.WriteLine(rectangle.Area());
            
            Geometri square = new Square();
            Console.WriteLine(square.Area());

            Geometri circle = new Circle();
            Console.WriteLine(circle.Area());
        }   
    }
}
