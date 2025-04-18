using Fib;
using NUnit.Framework;

namespace FibonacciTests;

[TestFixture]
public class FibonacciTests
{
    [TestCase(-1)]
    [TestCase(0)]
    public void ShouldThrowExceptionWhenNonPositiveNumber(int testInput)
    {
        Assert.Throws<ArgumentException>(() => Fibonacci.CalculateFibIndex(testInput));
    }
}
