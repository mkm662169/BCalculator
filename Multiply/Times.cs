using System;
using operations;

namespace Multiply
{
    public interface ITimes
    {
        public dynamic Multiply(dynamic a, dynamic b);
    }
    public class Times: ITimes
    {
        public dynamic solution;
        public dynamic Multiply(dynamic a, dynamic b)
        {
            solution = Multiplication.Multiply(a, b);
            return solution;
        }
    }
}
