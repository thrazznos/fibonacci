using Fib;
using NUnit.Framework;

namespace FibonacciTests;

[TestFixture]
public class FibonacciTests
{
    [TestCase(-1)]
    public void ShouldThrowExceptionWhenNegative(int testInput)
    {
        Assert.Throws<ArgumentException>(() => Fibonacci.CalculateFibIndex(testInput));
    }

    [TestCase(0, 1)]
    [TestCase(1, 2)]
    [TestCase(2, 4)]
    public void ShouldCalculateFibIndexForStartingNumbers(int testInput, int expectedOuput)
    {
        Assert.That(Fibonacci.CalculateFibIndex(testInput), Is.EqualTo(expectedOuput));
    }

    [TestCase(8, 7)]
    [TestCase(13, 8)]
    [TestCase(10946, 22)]
    public void ShouldCalculateCalculatedFibonacciNumbers(int testInput, int expectedOutput)
    {
        Assert.That(Fibonacci.CalculateFibIndex(testInput), Is.EqualTo(expectedOutput));
    }

    [TestCase(4)]
    [TestCase(9)]
    [TestCase(12)]
    public void ShouldThrowExceptionForNonFibonacciNumbers(int testInput)
    {
        Assert.Throws<FibonacciException>(() => Fibonacci.CalculateFibIndex(testInput));
    }
}
