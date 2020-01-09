using System;
using System.Collections.Generic;
using System.Text;

namespace operations
{
    public class Multiplication
    {
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static int Multiply(int[] arrayA)
        {
            int c = 1;
            foreach(int a in arrayA)
            {
                c = Multiply(c, a);
            }
            return c;
        }
        public static double Multiply(double[] arrayA)
        {
            double c = 1;
            foreach (double a in arrayA)
            {
                c = Multiply(c, a);
            }
            return c;
        }
    }
}
