using System;
using operations;
namespace Sum
{
    public class Adding: IAdd
    {
        public dynamic solution;
        public dynamic Add(dynamic a, dynamic b)
        {
            solution = Addition.Add(a, b);
            return solution;
        }
    }
}
