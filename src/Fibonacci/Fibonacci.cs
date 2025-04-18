namespace Fib
{
    public static class Fibonacci
    {
        //Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, ...
        public static int CalculateFibIndex(int n)
        {
            if (n < 0) throw new ArgumentException("Input must be a non-negative integer.");

            var fibSequence = new List<int> { 0, 1, 1, 2};

            if(n > fibSequence.Last())
            {
                while (fibSequence.Last() < n)
                {
                    int nextFib = fibSequence[^1] + fibSequence[^2];
                    fibSequence.Add(nextFib);
                }
            }
            if (fibSequence.Contains(n))
            {
                return fibSequence.IndexOf(n) + 1;
            }
            else
            {
                throw new FibonacciException($"The number {n} is not a Fibonacci number.");
            }
        }
    }
}
