using System;

namespace OOP_SqareCircle
{
    public class SquareCircle
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Random value will be set after three failed attempts.");
            Console.WriteLine("Input the side of a square : ");
            Square square = new Square(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Side: " + square.Side);
            Console.WriteLine("Square S: " + square.GetSquare());
            Console.WriteLine("Square diagonal: " + square.GetDiagonal());

            Console.WriteLine("Input the radius of the circle : ");
            Circle circle = new Circle(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("S of Circle : " + circle.GetArea());
            Console.Read();
            Console.WriteLine("Diametr of a circle: " + circle.GetDiametr());
            Console.Read();

            var ds = square.GetDiagonal();
            var dc = circle.Diametr;
            if (ds < dc)
            {
                Console.WriteLine("Square fits inside Circle. Circle doesn't fit inside Square.");
            }
            else
            {
                Console.WriteLine("Square DOESN'T fit inside Circle. Circle fits inside Square");
            }
        }
    }
}
