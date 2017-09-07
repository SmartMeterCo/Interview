using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace RandomNumber.Tests
{
    public class RandomGeneratorTests
    {
        [Fact]
        public void RandomGenerator_GetRandomNumber_AllResultsBetweenZeroAndOne()
        {
            //Arrange 
            var randomGenerator = new RandomGenerator();
            var i = 0;
            var results = new List<int>();

            //Act 
            while (i < 1000)
            {
                results.Add(randomGenerator.GetRandomNumber());
                i++;
            }
            var resultsOverOne = results.Where(x => x > 1).Select(x => x).ToList();

            //Assert 
            Assert.Empty(resultsOverOne);
        }
    }
}
