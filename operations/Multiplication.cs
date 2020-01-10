namespace operations
{
    public class Multiplication
    {
        public static dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }
        /*public static double Multiply(double a, double b)
        {
            return a * b;
        }*/
        public static dynamic Multiply(dynamic[] arrayA)
        {
            dynamic c = 1;
            foreach (dynamic a in arrayA)
            {
                c = Multiply(c, a);
            }
            return c;
        }
        /*public static double Multiply(double[] arrayA)
        {
            double c = 1;
            foreach (double a in arrayA)
            {
                c = Multiply(c, a);
            }
            return c;
        }*/
    }
}
