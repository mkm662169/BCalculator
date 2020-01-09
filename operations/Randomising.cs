using System;
using System.Collections.Generic;
using System.Text;

namespace operations
{
    public class Randomising
    {
        private static object random;

        public int Randomise(int min, int max)
        {
            Random random = new Random(0);
            return random.Next(min, max);
        }

    }
}
