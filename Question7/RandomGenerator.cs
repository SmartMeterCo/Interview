using System;
using System.Collections.Generic;
using System.Text;

namespace Question7
{
    public class RandomGenerator
    {
        public int GetRandomNumber()
        {
            var random = new Random();
            return random.Next(0, 2);
        }
        
    }
}
