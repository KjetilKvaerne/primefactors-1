using System.Collections.Generic;

namespace Kjetil.Kata.Primefactors
{
    public class Primefactors2
    {
        public static IEnumerable<int> Of(int number)
        {
            for (var factor = 2; factor < number; factor++)
            {
                while (number % factor == 0)
                {
                    number /= factor;
                    yield return factor;
                }
            }

            if (number > 1)
                yield return number;
        }
    }
}