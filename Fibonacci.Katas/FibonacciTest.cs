using Xunit;

namespace Fibonacci.Katas.Tests
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        [InlineData(5, 3)]
        [InlineData(6, 5)]
        [InlineData(10, 34)]
        [InlineData(15, 377)]
        public void GetFibonacciNumberForGivenPosition(int position, int expectedNumber)
        {
            FibonacciGame fibonacciGame = new FibonacciGame();

            var actualNumber = fibonacciGame.GetFibonacci(position);

            Assert.Equal(expectedNumber, actualNumber);
        }

    }
}
