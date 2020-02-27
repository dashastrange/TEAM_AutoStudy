using System;
namespace OOP_SqareCircle
{
    public class Circle
    {
        public double radius, s_cir;
        public const double PI = 3.14;
        public double Diametr;

        public double GetDiametr()
        {
            Diametr = Math.Sqrt(GetS() / PI) * 2;
            return Diametr;
        }

        public double GetS()
        {
            double s_cir = PI * radius * radius;
            return s_cir;
        }
    }
}
