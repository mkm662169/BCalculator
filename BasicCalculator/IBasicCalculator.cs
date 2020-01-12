namespace BasicCalculator
{
    public interface IBasicCalculator
    {
        public dynamic Add(dynamic a, dynamic b);

        public dynamic Add(dynamic values);

        public dynamic Cubing(dynamic a);

        public dynamic Difference(dynamic a, dynamic b);

        public dynamic Difference(dynamic values);

        public dynamic Multiply(dynamic a, dynamic b);

        public dynamic Multiply(dynamic values);

        public dynamic Quotient(dynamic a, dynamic b);

        public dynamic Square(dynamic a);

        public dynamic SquareRoot(dynamic a);
    }
}
