using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCalculator
{
    public interface IBasicCalculator
    {
        public dynamic Add(dynamic a, dynamic b);

        public dynamic Cubing(dynamic a);

        public dynamic Difference(dynamic a, dynamic b);

        public dynamic Multiply(dynamic a, dynamic b);

        public dynamic Quotient(dynamic a, dynamic b);

        public dynamic Square(dynamic a);

        public dynamic SquareRoot(dynamic a);
    }
}
