using System.Diagnostics;
using System.Linq;
using Xunit;

namespace Kjetil.Kata.Primefactors
{
    public class PrimefactorsTest
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2, 2)]
        [InlineData(4, 2, 2)]
        [InlineData(6, 2, 3)]
        [InlineData(8, 2, 2, 2)]
        [InlineData(9, 3, 3)]
        [InlineData(12, 2, 2, 3)]
        public void Of_Number_ExpectedResult(int number, params int[] expected)
        {
            Assert.Equal(expected, Primefactors.Of(number));
            Assert.Equal(expected, Primefactors2.Of(number));
        }

        [Fact]
        public void Acceptance()
        {
            var expected = new[] { 5, 7, 11, 13, 17, 19, 23, 29 };

            Assert.Equal(expected, Primefactors.Of(expected.Aggregate(1, (a, b) => a * b)));
            Assert.Equal(expected, Primefactors2.Of(expected.Aggregate(1, (a, b) => a * b)));
        }

        [Fact]
        public void Performance()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Primefactors.Of(int.MaxValue);
            stopwatch.Stop();
            Assert.True(stopwatch.ElapsedMilliseconds < 2000, $"Performance issue, running for {stopwatch.ElapsedMilliseconds} ms.");
        }
    }
}
