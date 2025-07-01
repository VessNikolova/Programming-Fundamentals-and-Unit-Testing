using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class DuplicatesTests
{
    [Test]
    public void Test_RemoveDuplicates_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] originalArr = Array.Empty<int>();
        int[] expectedArr = Array.Empty<int>();

        // Act
        int[] actualArr = Duplicates.RemoveDuplicates(originalArr);

        // Assert
        CollectionAssert.AreEqual(expectedArr, actualArr);
    }

    [Test]
    public void Test_RemoveDuplicates_NoDuplicates_ReturnsOriginalArray()
    {
        // Arrange
        int[] originalArr = new int[]{ 43, 75, 75473, 5066990, 5463563};

        // Act
        int[] actualArr = Duplicates.RemoveDuplicates(originalArr);

        // Assert
        CollectionAssert.AreEqual(originalArr, actualArr);
    }

    [Test]
    public void Test_RemoveDuplicates_SomeDuplicates_ReturnsUniqueArray()
    {
        // Arrange
        int[] originalArr = new int[] { 43, 75473, 75, 75473, 5066990, 43, 5463563 };
        int[] expectedArr = new int[] { 43, 75473, 75, 5066990, 5463563 };

        // Act
        int[] actualArr = Duplicates.RemoveDuplicates(originalArr);

        // Assert
        CollectionAssert.AreEqual(expectedArr, actualArr);
    }

    [Test]
    public void Test_RemoveDuplicates_AllDuplicates_ReturnsSingleElementArray()
    {
        // Arrange
        int[] originalArr = new int[] { 43, 43, 43, 43, 43 };
        int[] expectedArr = new int[] { 43 };

        // Act
        int[] actualArr = Duplicates.RemoveDuplicates(originalArr);

        // Assert
        CollectionAssert.AreEqual(expectedArr, actualArr);
    }
}
