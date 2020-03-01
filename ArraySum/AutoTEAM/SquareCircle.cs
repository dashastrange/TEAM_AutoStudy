using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoTEAM
{
    public class SquareCircle
    {
        static void Main()
        {
            SquareCircleFit();
            
        }

        public static void SquareCircleFit()
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

            double Diagonal = Side * Math.Sqrt(2);

            if (Diagonal <= Diametr)
                Console.WriteLine("Square. It fits!");

            else
                Console.WriteLine("Square. Doesn't fit!");

            Console.ReadKey();
        }
    }
}
