using System;
namespace OOP_SqareCircle
{
    public interface ISquareFit
    {
        void SquareFit();
    }

    class SquareFits : ISquareFit
    {
        public void SquareFit()
        {
            Console.WriteLine("Square. Enter side");
            double S2 = Console.Read();
            Square Side = new Square(S2);
            double Diagonal = Square.Side * Math.Sqrt(2);

            if (Diagonal <= Diametr)
                Console.WriteLine("Square. It fits!");

            else
                Console.WriteLine("Square. Doesn't fit!");

            Console.ReadKey();
        }
    }

}
