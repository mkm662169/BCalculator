using System;
using operations;
namespace Difference
{
    
    public class Subtracting: IDifferences
    {
        public dynamic solution;

        public dynamic Minus(dynamic a, dynamic b)
        {
            solution = Subtraction.Minus(a, b);
            return solution;
        }
    }
}
