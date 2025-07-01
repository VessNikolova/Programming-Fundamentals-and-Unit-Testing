using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PrimeNumberFinderTests
{
    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithLessThanOrEqualToOneElementsOnly_ReturnsEmptyArray()
    {
        int[] arr = new int[] { 1, 1, 0, -5 };

        PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();

        int[] expected = new int[] { };

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOneNonPrimeNumber_ReturnsEmptyArray()
    {
        int[] arr = new int[] {6};

        PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();

        int[] expected = new int[] { };

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithNoPrimeNumbersOnly_ReturnsEmptyArray()
    {
        int[] arr = new int[] { 18, 4, 10, 22 };

        PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();

        int[] expected = new int[] {};

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithOnlyOnePrimeNumber_ReturnsArrayWithTheSameNumber()
    {
        int[] arr = new int[] { 10, 7, 6, 24 };

        PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();

        int[] expected = new int[] {7};

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetAllPrimeNumbers_InputArrayWithMixedNumbers_ReturnsArrayOnlyWithPrimeNumbers()
    {
        int[] arr = new int[] { 1, 4, 6, 7, 22, 23, 37, 55 };

        PrimeNumberFinder primeNumberFinder = new PrimeNumberFinder();

        int[] expected = new int[] {7, 23, 37};

        int[] result = PrimeNumberFinder.GetAllPrimeNumbers(arr);

        Assert.That(result, Is.EqualTo(expected));
    }
}
