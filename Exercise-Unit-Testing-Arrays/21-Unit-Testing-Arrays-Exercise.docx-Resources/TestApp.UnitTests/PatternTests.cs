using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        int[] originalArr = new int[] { 2, 3, 4, 3, 1, 8, 7, 9 };
        int[] expectedArr = new int[] { 1, 9, 2, 8, 3, 7, 4 };

        int[] actualArr = Pattern.SortInPattern(originalArr);

        CollectionAssert.AreEqual(expectedArr, actualArr);
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        int[] originalArr = Array.Empty<int>();

        int[] actualArr = Pattern.SortInPattern(originalArr);

        CollectionAssert.AreEqual(originalArr, actualArr);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        int[] originalArr = new int[] { 2 };

        int[] actualArr = Pattern.SortInPattern(originalArr);

        CollectionAssert.AreEqual(originalArr, actualArr);
    }
}
