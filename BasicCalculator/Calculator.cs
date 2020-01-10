using operations;

namespace BasicCalculator
{
    public class Calculator
    {
        public int solution;
        public dynamic Add(dynamic a, dynamic b)
        {
            solution = Addition.Add(a, b);
            return solution;
        }

        /*public double Divide(double a, double b)
        {
            solution = Division.Divide(a, b);
            return solution;
        }*/
    }
}
