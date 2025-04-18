namespace Fib
{
    public class FibonacciException: Exception
    {
        public FibonacciException() : base("Error occured in fibonacci calculation")
        {
        }

        public FibonacciException(string message): base(message)
        {

        }
    }
}
