using System;
using StatOperations;

namespace Mean
{
    public class Meaning : IMeans
    {
        public dynamic solution;
        public dynamic Mean(dynamic values)
        {
            solution = StatMean.Mean(values);
            return solution;
        }
    }
}
