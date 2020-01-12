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
    }
}
