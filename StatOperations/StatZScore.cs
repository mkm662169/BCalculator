using System;
using System.Collections.Generic;
using System.Text;
using StatOperations;
using operations;
using Helpers;

namespace StatOperations
{
    public class StatZScore
    {
        public static double ZScore(dynamic score, dynamic mean, dynamic stdDev)
        {
            var zScore = Division.Divide(Subtraction.Minus(score, mean), stdDev);
            return zScore;
        }
    }
}
