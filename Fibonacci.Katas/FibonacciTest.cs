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

        [Fact]
        public void GetFibonacciNumberForPositionTwo()
        {
            FibonacciGame fibonacciGame = new FibonacciGame();

            var actualNumber = fibonacciGame.GetFibonacci(2);

            Assert.Equal(1,actualNumber);
        }

        [Fact]
        public void GetFibonacciNumberForPositionThree()
        {
            FibonacciGame fibonacciGame = new FibonacciGame();

            var actualNumber = fibonacciGame.GetFibonacci(3);

            Assert.Equal(1,actualNumber);
        }
    }

    public class FibonacciGame
    {
        public int GetFibonacci(int position)
        {
            if (position == 1)
                return 0;
            if (position == 2 || position==3)
                return 1;

            return 0;
        }
    }
}
