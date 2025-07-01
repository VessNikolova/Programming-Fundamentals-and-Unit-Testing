using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class EvenOddSubtractionTests
{
    [Test]
    public void Test_FindDifference_InputIsEmpty_ShouldReturnZero()
    {
        // Arrange
        int[] emptyArray = Array.Empty<int>();

        // Act
        int result = EvenOddSubtraction.FindDifference(emptyArray);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [TestCase(new int[] {2,6,8,4}, 20)]
    [TestCase(new int[] {-2,-6,-8,-4}, -20)]
    [TestCase(new int[] {4,6,12,8}, 30)]
    public void Test_FindDifference_InputHasOnlyEvenNumbers_ShouldReturnEvenSum(int[] arr, int expected)
    {
        // Arrange
       
        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindDifference_InputHasOnlyOddNumbers_ShouldReturnNegativeOddSum()
    {
        // Arrange
        int[] arr = new int[] {3, 5, 1 };

        int expected = -9;
        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(new int[] {2,3,5,6,7}, -7)]
    [TestCase(new int[] {7,1,5,8,7,10}, -2)]
    [TestCase(new int[] {5,9,5,6,7}, -20)]
    public void Test_FindDifference_InputHasMixedNumbers_ShouldReturnDifference(int[] arr, int expected)
    {
        // Arrange
     
        // Act
        int result = EvenOddSubtraction.FindDifference(arr);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
