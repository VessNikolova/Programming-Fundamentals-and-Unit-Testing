using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class RepeatingChecker_LastReapeatingElementTests
{
    [Test]
    public void Test_FindLastRepeatingElement_EmptyArray_ReturnsNegativeOne()
    {
        int[] originalArr = Array.Empty<int>();
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithOneInteger_ReturnsNegativeOne()
    {
        int[] originalArr = new int[] {19};
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyNonRepeatingValues_ReturnsNegativeOne()
    {
        int[] originalArr = new int[] { 19, 1, -4, 9, -23, 50, -11 };
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithTwoReapeatingNegativeOneValue_ReturnsNegativeOne()
    {
        int[] originalArr = new int[] { 19, -1, 6, -23, -17, 7, -1, 4 };
        int expected = -1;

        int actual = RepeatingChecker.FindLastRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithManyIntegerWithSameValues_ReturnsTheIntegerValue()
    {
        int[] originalArr = new int[] { 11, 11, 11, 11, 11, 11 };
        int expected = 11;

        int actual = RepeatingChecker.FindLastRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindLastRepeatingElement_ArrayWithAtLeastTwoReaptingValues_ReturnsTheRepeatingValue()
    {
        int[] originalArr = new int[] { 19, 5, 19, 19, 7, -23, 9, -43, 6, -23 };
        int expected = -23;

        int actual = RepeatingChecker.FindLastRepeatingElement(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
