namespace Fibonacci.Katas.Tests
{
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