using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeFactorTests
{
    [TestCase(2)]
    [TestCase(7)]
    [TestCase(11)]
    [TestCase(389)]
    public void Test_FindLargestPrimeFactor_PrimeNumber(int primeNumber)
    {
        long result = PrimeFactor.FindLargestPrimeFactor(primeNumber);

        Assert.That(result, Is.EqualTo(primeNumber));
    }

    [Test]
    public void Test_FindLargestPrimeFactor_LargeNumber()
    {
        long number = 48625;
        int expected = 389;
        
        long result = PrimeFactor.FindLargestPrimeFactor(number);

        Assert.That(result, Is.EqualTo(expected));
    }
}
