using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    // TODO: finish test
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = "";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("", result, "String is not empty.");
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "v";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("v", result, "String is not the same character.");
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "vess";

        // Act
        string result = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual("ssev", result, "String is not reversed.");
    }
}
