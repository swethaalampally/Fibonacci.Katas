using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Xunit;

namespace Fibonacci.Katas
{
    public class FibonacciTest
    {
        [Theory]
        [InlineData(1, 0)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        [InlineData(4, 2)]
        public void GetFibonacciNumberForGivenPosition(int position, int expectedNumber)
        {
            FibonacciGame fibonacciGame = new FibonacciGame();

            var actualNumber = fibonacciGame.GetFibonacci(position);

            Assert.Equal(expectedNumber, actualNumber);
        }

    }

    public class FibonacciGame
    {
        public int GetFibonacci(int position)
        {
            if (position == 1)
                return 0;
            if (position == 2 || position == 3)
                return 1;

            int result = GetFibonacci(position - 1) + GetFibonacci(position - 2);

            return result;
        }
    }
}
