using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TopIntegersTests
{
    private TopIntegers topIntegers;

    [SetUp]
    public void TestInitialization()
    {
        topIntegers = new TopIntegers();
    }
    [Test]
    public void Test_FindTopIntegers_EmptyArrayParameter_ReturnEmptyString()
    {
        int[] originalArr = Array.Empty<int>();
        string expected = string.Empty;

        string actual = topIntegers.FindTopIntegers(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_AllElementsAreTopIntegers_ReturnStringWithAllElements()
    {
        int[] originalArr = new int[] {9, 6, 5, 2, 1};
        string expected = "9 6 5 2 1";

        string actual = topIntegers.FindTopIntegers(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlyOneElementArray_ReturnStringWithOneInteger()
    {
        int[] originalArr = new int[] { 7 };
        string expected = "7";

        string actual = topIntegers.FindTopIntegers(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindTopIntegers_OnlySomeElementsAreTopIntegers_ReturnStringWithOnlyTopIntegers()
    {
        int[] originalArr = new int[] { 9, 22, 56, 6, 43, 10, 17, 40, 5};
        string expected = "56 43 40 5";

        string actual = topIntegers.FindTopIntegers(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}

