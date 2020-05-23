using System;
using System.Collections.Generic;
using System.Text;

namespace Dinner.Service
{
    static class RandomNumberService
    {
        static Random s_random;
        public static int Generate(int max)
        {
            s_random = (s_random == null) ? new Random() : s_random;
            return s_random.Next(0, max);
        }
    }
}
