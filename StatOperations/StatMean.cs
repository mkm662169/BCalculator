using System;
using operations;
using Helpers;

namespace StatOperations
{
    public class StatMean
    {
        public static dynamic Mean(dynamic values)
        {
            var sum = Addition.Add(values);
            var valueCount = Helpers.Array.Length(values);
            var mean = Division.Divide(sum, valueCount);
            return mean;
        }
    }
}
