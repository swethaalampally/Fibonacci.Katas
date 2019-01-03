using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Xunit;

namespace Fibonacci.Katas
{
    public class FibonacciTest
    {
        [Fact]
        public void GetFibonacciNumberForPositionOne()
        {
            FibonacciGame fibonacciGame = new FibonacciGame();
            var actualNumber = fibonacciGame.GetFibonacci(1);
            Assert.Equal(0, actualNumber);
        }
    }

    public class FibonacciGame
    {
        public int GetFibonacci(int position)
        {
            return position == 1 ? 0 : 1;
        }
    }
}
