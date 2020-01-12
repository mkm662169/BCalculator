namespace operations
{
    public class Subtraction
    {
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static double Minus(double a, double b)
        {
            return a - b;
        }
        public static int Minus(int[] arrayA)
        {
            int c = 0;
            foreach (int a in arrayA)
            {
                c = Minus(c, a);
            }
            return c;
        }
        public static double Minus(double[] arrayA)
        {
            double c = 0.0;
            foreach (int b in arrayA)
            {
                c = Minus(c, b);
            }
            return c;
        }
    }
}
