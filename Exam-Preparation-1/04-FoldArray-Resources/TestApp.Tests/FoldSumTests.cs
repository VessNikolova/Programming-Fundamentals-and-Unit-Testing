using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [TestCase(new int[]{1, 2, 3, 4, 5, 6, 7, 8}, "5 5 13 13")]
    [TestCase(new int[0], "")]
    [TestCase(new int[]{9, 3, 4, 5, 2, 1, 11, 7}, "7 14 9 12")]
    [TestCase(new int[]{3, 3, 2, 2, 1, 1, 5, 5}, "5 5 6 6")]
    [TestCase(new int[]{8, 7, 2, 4, 3, 1, 9, 6}, "9 12 9 10")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        string result = FoldSum.FoldArray(arr);

        Assert.That(result, Is.EqualTo(expected));
    }
}
