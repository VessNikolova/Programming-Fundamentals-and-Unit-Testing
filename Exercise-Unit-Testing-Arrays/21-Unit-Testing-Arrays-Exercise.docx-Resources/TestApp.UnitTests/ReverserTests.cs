using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class ReverserTests
{
    [Test]
    public void Test_ReverseStrings_WithEmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        string[] inputArray = Array.Empty<string>();

        // Act
        string[] result = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ReverseStrings_WithSingleString_ReturnsReversedString()
    {
        // Arrange
        string[] inputArray = new string[]{ "computer" };
        string[] expectedArr = new string[] { "retupmoc" };
        ;

        // Act
        string[] resultArr = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(resultArr, Is.EqualTo(expectedArr));
    }

    [Test]
    public void Test_ReverseStrings_WithMultipleStrings_ReturnsReversedStrings()
    {
        // Arrange
        string[] inputArray = new string[] { "computer", "python", "java", "javascript" };
        string[] expectedArr = new string[] { "retupmoc", "nohtyp", "avaj", "tpircsavaj" };
        ;

        // Act
        string[] resultArr = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(resultArr, Is.EqualTo(expectedArr));
    }

    [Test]
    public void Test_ReverseStrings_WithSpecialCharacters_ReturnsReversedSpecialCharacters()
    {
        // Arrange
        string[] inputArray = new string[] { "com?#|", "|@/=-", "#%$&" };
        string[] expectedArr = new string[] { "|#?moc", "-=/@|", "&$%#" };
        ;

        // Act
        string[] resultArr = Reverser.ReverseStrings(inputArray);

        // Assert
        Assert.That(resultArr, Is.EqualTo(expectedArr));
    }
}
