using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(null));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        int[] arr = new int[0];

        string actual = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(actual, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        int[] arr = new int[] {3};
        string expected = "3";

        string actual = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        int[] arr = new int[] { 3, 5, 9, 1, 7, 12, 4, 8, 23 };
        string expected = "3 5 9 12 23";

        string actual = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        int[] arr = new int[] { 3, 5, 9, 17, 45 };
        string expected = "3 5 9 17 45";

        string actual = LongestIncreasingSubsequence.GetLis(arr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
