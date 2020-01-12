using System;
using System.Collections.Generic;
using System.Text;
using StatOperations;
using operations;

namespace StatOperations
{
    public class StatStandDev
    {
        public static double StandDev(dynamic values)
        {
            double variance = StatVariance.Variance(values);
            double standDev = Root.Sqrt(variance);

            return standDev;
        }
    }
}
