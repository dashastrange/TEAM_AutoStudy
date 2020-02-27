using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(4);
        Console.WriteLine("Side: " + square.Side);
        Console.WriteLine("Square S: " + square.GetSquare());
        Console.WriteLine("Square P: " + square.GetPerimetr());
    }
}