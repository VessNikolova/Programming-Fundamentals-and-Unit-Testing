using NUnit.Framework;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        int number = 0;

        int result = Fibonacci.CalculateFibonacci(number);

        Assert.That(result, Is.EqualTo(number));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        int number = 7;
        int expected = 13;

        int result = Fibonacci.CalculateFibonacci(number);

        Assert.That(result, Is.EqualTo(expected));
    }
}