using System;
namespace OOP_SqareCircle
{
    public interface ICircleFit
    {
        void CircleFit();
    }

    class CircleFits : ICircleFit
    {
        public void CircleFit()
        {
            const double P = 3.14;

            Console.Write("Circle S: ");
            double S1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Square S: ");
            double S2 = Convert.ToDouble(Console.ReadLine());

            double Diametr = Math.Sqrt(S1 / P) * 2;
            double Side = Math.Sqrt(S2);

            if (Diametr <= Side)
            {
                Console.WriteLine();
                Console.WriteLine("Circle. It fits!");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Circle. Doesn't fit!");
            }
        }
    }
}
