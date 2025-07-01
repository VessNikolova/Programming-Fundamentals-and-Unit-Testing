using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void Test_CalculateFactorial_InputZero_ReturnsOne()
    {
        int expected = 1;

        int result = Factorial.CalculateFactorial(0);

        Assert.AreEqual(expected, result);
    }

    [Test]
    public void Test_CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        int expected = 120;

        int result = Factorial.CalculateFactorial(5);

        Assert.AreEqual(expected, result);
    }
}
