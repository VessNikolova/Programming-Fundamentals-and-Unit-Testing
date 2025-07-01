using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MaxNumberTests
{

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        List<int> list = new List<int> { 3 };

        int expected = 3;

        int result = MaxNumber.FindMax(list);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        List<int> list = new List<int> { 3, 11, 5, 8, 7 };

        int expected = 11;

        int result = MaxNumber.FindMax(list);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        List<int> list = new List<int> { -3, -5, -13, -1, -23, -8 };

        int expected = -1;

        int result = MaxNumber.FindMax(list);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        List<int> list = new List<int> { -4, -17, 8, 4, 11, -9 };

        int expected = 11;

        int result = MaxNumber.FindMax(list);

        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        List<int> list = new List<int> { 3, -5, 7, 12, 5, -8, 12, 1 };

        int expected = 12;

        int result = MaxNumber.FindMax(list);

        Assert.That(expected, Is.EqualTo(result));
    }
}
