using StatOperations;

namespace StatsCalculator
{
    public class StatisticsCalculator
    {
        public dynamic solution;
        public dynamic Mean(dynamic values)
        {
            solution = StatMean.Mean(values);
            return solution;
        }

        public dynamic Variance(dynamic values)
        {
            solution = StatVariance.Variance(values);
            return solution;
        }

        public dynamic StandDev(dynamic values)
        {
            solution = StatStandDev.StandDev(values);
            return solution;
        }
    }
}
