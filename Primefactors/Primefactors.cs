using System;
using System.Collections.Generic;

namespace Kjetil.Kata.Primefactors
{
    public class Primefactors
    {
        public static IEnumerable<int> Of(int number)
        {
            var primefactors = new List<int>();
            for (var factor = 2; factor <= Math.Sqrt(number); factor++)
            {
                while (number % factor == 0)
                {
                    primefactors.Add(factor);
                    number = number / factor;
                }
            }

            if (number > 1)
                primefactors.Add(number);

            return primefactors;
        }
    }
}
