using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailTests
{
    // TODO: finish test
    [TestCase("ves@abv.bg")]
    [TestCase("uni@unwe.com")]
    [TestCase("chris@mail.de")]
    public void Test_IsValidEmail_ValidEmail(string validEmail)
    {
        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.True);
    }

    [TestCase("test@@example.com")]
    [TestCase("example.com")]
    [TestCase("test@")]
    public void Test_IsValidEmail_InvalidEmail(string validEmail)
    {
        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.False);
    }

    [Test]
    public void Test_IsValidEmail_NullInput()
    {
        // Arrange
        string validEmail = "";

        // Act
        bool result = Email.IsValidEmail(validEmail);

        // Assert
        Assert.That(result, Is.False);
    }
}
