using operations;
using Sum;
using Multiply;
using Quotient;
using Difference;
using SquareRoot;
using Cubing;
using Square;

namespace BasicCalculator
{
    public class Calculator: IAdd, ITimes, IDivides, IDifferences, ISquareRooting, ICubing, ISquared
    {
        // Creating objects
        readonly Adding add = new Adding();
        readonly Times time = new Times();
        readonly Dividing divide = new Dividing();
        readonly Subtracting subtract = new Subtracting();
        readonly SquareRoots squareRoots = new SquareRoots();
        readonly Cubes cubes = new Cubes();
        readonly Squares square = new Squares();

        public dynamic solution;
        public dynamic Add(dynamic a, dynamic b)
        {
            solution = Addition.Add(a, b);
            return solution;
        }

        public dynamic Divide(dynamic a, dynamic b)
        {
            solution = Division.Divide(a, b);
            return solution;
        }

        public dynamic Multiply(dynamic a, dynamic b)
        {
            solution = Multiplication.Multiply(a, b);
            return solution;
        }
        public dynamic Minus(dynamic a, dynamic b)
        {
            solution = Subtraction.Minus(a, b);
            return solution;
        }
        public dynamic Sqrt(dynamic a)
        {
            solution = Root.Sqrt(a);
            return solution;
        }
        public dynamic Cubed(dynamic a)
        {
            solution = Cube.Cubed(a);
            return solution;
        }
        public dynamic Squared(dynamic a)
        {
            solution = a * a;
            return solution;
        }
    }
}
