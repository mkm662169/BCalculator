namespace operations
{
    public class Addition
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        /*public static double Add(double a, double b)
        {
            return a + b;
        }*/
        public static dynamic Add(dynamic[] arrayA)
        {
            dynamic c = 0;
            foreach (dynamic a in arrayA)
            {
                c = Add(c, a);
            }

            return c;
        }
        /*public static double Add(double[] arrayA)
        {
            double c = 0.0;
            foreach (double a in arrayA)
            {
                c = Add(c, a);
            }
            return c;
        }*/
    }
}
