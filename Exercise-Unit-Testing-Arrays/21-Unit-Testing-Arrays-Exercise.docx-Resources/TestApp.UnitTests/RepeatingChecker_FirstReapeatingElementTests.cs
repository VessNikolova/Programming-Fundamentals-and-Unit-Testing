using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_FirstReapeatingElementTests
{
    [Test]
    public void Test_FindFirstRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] originalArr = Array.Empty<int>();
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        int[] originalArr = new int[] { 5 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        int[] originalArr = new int[] { 5, 13, 16, 3, 7, 9, 43, 56 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        int[] originalArr = new int[] { 5, -1, 4, 0, 9, -1, 23, 13 };
        int expected = -1;

        int actual = RepeatingChecker.FindFirstRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        int[] originalArr = new int[] { 13, 13, 13, 13, 13, 13, 13 };
        int expected = 13;

        int actual = RepeatingChecker.FindFirstRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindFirstRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        int[] originalArr = new int[] { 5, 7, 13, 7, 9, 23, 50, 9 };
        int expected = 7;

        int actual = RepeatingChecker.FindFirstRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
