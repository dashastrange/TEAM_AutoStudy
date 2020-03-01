using System;
namespace OOP_SqareCircle
{
    public class Circle
    {
        public double radius, s_cir;
        public const double PI = 3.14;
        public double Diametr;

        public Circle(double circleRadius)
        {
            radius = circleRadius;
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double GetDiametr()
        {
            Diametr = Math.Sqrt(GetArea() / PI) * 2;
            return Diametr;
        }

        public double GetArea()
        {
            double s_cir = PI * radius * radius;
            return s_cir;
        }
    }
}
