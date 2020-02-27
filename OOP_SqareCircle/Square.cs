using System;
namespace OOP_SqareCircle
{
    class Square
    {
        //Square side
        double side;
        public Square(double s)
        {
            side = s;
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

        //Square S
        public double GetSquare()
        {
            return side * side;
        }

        //Diagonal
        public double GetDiagonal()
        {
            double Diagonal = side * Math.Sqrt(2);
            return Diagonal;
        }
        

    }
}
