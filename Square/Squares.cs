using System;
using operations;

namespace Square
{
    public interface ISquared
    {
        public dynamic Squared(dynamic a);
    }
    public class Squares: ISquared
    {
        public dynamic solution;

        public dynamic Squared(dynamic a)
        {
            solution = a * a;
            return solution;
        }
    }
}
