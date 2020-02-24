using System;
namespace NUNIT_1
{
    public class ScientificCalculator : Calculator
    {

        public double Pow(double a, double b)
        {
            double num_pow = Math.Pow(a, b);
            return num_pow;
        }
        public double Percent(double a, double b)
        {
            double num_percent = (a + (b / 100));
            return num_percent;
        }
        public int Mod(int a, int b)
        {
            int num_mod = a % b;
            return num_mod;
        }
        public double Sqrt(double a)
        {
            double num_sqrt = Math.Sqrt(a);
            return num_sqrt;
        }
    }
}
