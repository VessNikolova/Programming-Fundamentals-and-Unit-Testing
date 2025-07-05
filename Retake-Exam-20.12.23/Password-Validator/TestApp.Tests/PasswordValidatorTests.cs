using NUnit.Framework;

namespace TestApp.Tests;

public class PasswordValidatorTests
{
    [Test]
    public void Test_CheckPassword_ValidPassword_ReturnsValidMessage()
    {
        string password = "abcd1234";
        string expected = "Password is valid";

        string actual = PasswordValidator.CheckPassword(password);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_PasswordTooShort_ReturnsErrorMessage()
    {
        string password = "ab34";
        string expected = "Password must be between 6 and 10 characters";

        string actual = PasswordValidator.CheckPassword(password);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ContainsSpecialCharacters_ReturnsErrorMessage()
    {
        string password = "ab34%$!";
        string expected = "Password must consist only of letters and digits";

        string actual = PasswordValidator.CheckPassword(password);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_InsufficientDigits_ReturnsErrorMessage()
    {
        string password = "softuni";
        string expected = "Password must have at least 2 digits";

        string actual = PasswordValidator.CheckPassword(password);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckPassword_ValidPasswordWithMaximumLength_ReturnsValidMessage()
    {
        string password = "veselina89";
        string expected = "Password is valid";

        string actual = PasswordValidator.CheckPassword(password);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
