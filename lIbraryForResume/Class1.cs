using System;

namespace lIbraryForResume
{
    public class Class1
    {
        const double PI = 3.14;

        public static double Square(double r) => PI * Math.Pow(r, 2);
        public static double Square(double a,double b,double c)
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
