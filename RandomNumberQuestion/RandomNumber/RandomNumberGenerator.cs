using System;
using System.Collections.Generic;
using System.Text;

namespace RandomNumber
{
    public class RandomNumberGenerator
    {
        private readonly RandomGenerator _randomGenerator;
        public RandomNumberGenerator()
        {
            _randomGenerator = new RandomGenerator();
        }
        public int Generate(int userInput)
        {
            throw new NotImplementedException();
        }
    }
}
