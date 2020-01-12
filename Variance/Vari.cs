using System;
using StatOperations;

namespace Variance
{
    public class Vari : IVariances
    {
        public dynamic solution;

        public dynamic Variance(dynamic values)
        {
            solution = StatVariance.Variance(values);
            return solution;
        }
    }
}
