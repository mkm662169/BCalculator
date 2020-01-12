using System;
using StatOperations;

namespace StandDev
{
    public class StandardDeviation : IStandardDev
    {
        public dynamic solution;

        public dynamic StandDev(dynamic values)
        {
            solution = StatStandDev.StandDev(values);
            return solution;
        }
    }
}
