using System;
using operations;

namespace Quotient
{
    public interface IDivides
    {
        public dynamic Divide(dynamic a, dynamic b);
    }
    public class Dividing: IDivides
    {
        public dynamic solution;

        public dynamic Divide(dynamic a, dynamic b)
        {
            solution = Division.Divide(a, b);
            return solution;
        }
    }
}
