using System;

namespace operations
{
    public class Randomising
    {
        private readonly dynamic Seed;
        //private static object random;
        public Randomising(dynamic seed)
        {
            Seed = seed;
        }
        public int GenerateRandomNumber(int min, int max)
        {
            Random random = new Random(Seed);
            var randomNumber = random.Next(min, max);
            return randomNumber;
        }

    }
}
