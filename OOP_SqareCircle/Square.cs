using System;
namespace OOP_SqareCircle
{
    public class Square
    {
        //Square side
        public double side;
        public double squareArea;
        public Square(double squareSide)
        {
            side = squareSide;
            squareArea = squareSide * 2;
        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }

        internal static bool IsNullOrEmpty(Square square)
        {
            throw new NotImplementedException();
        }

        //Square S
        public double GetSquare()
        {
            return squareArea;
        }

        //Diagonal
        public double GetDiagonal()
        {
            double Diagonal = side * Math.Sqrt(2);
            return Diagonal;
        }
    }
}
