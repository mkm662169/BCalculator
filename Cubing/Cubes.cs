using System;
using operations;

namespace Cubing
{
    public interface ICubing
    {
        public dynamic Cubed(dynamic a);
    }
    public class Cubes: ICubing
    {
        public dynamic solution;

        public dynamic Cubed(dynamic a)
        {
            solution = Cube.Cubed(a);
            return solution;
        }
    }
}
