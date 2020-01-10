namespace operations
{
    public static class Division
    {
         public static dynamic Divide(dynamic a, dynamic b)
         {
             return a / b;
         }
       /* public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        public static dynamic Divide(dynamic[] arrayB)
        {
            dynamic d = arrayB[0];

            for (int i = 1; i < arrayB.Length; i++)
            {
                d = Divide(d, arrayB[i]);
            }
            return d;
        }
        public static double Quotient(double[] arrayA)
        {
            double c = arrayA[0];

            foreach (double a in arrayA)
            {
                c = Divide(c, a);
            }
            double d = c * arrayA[0];
            return d;
        }*/
    }
}
