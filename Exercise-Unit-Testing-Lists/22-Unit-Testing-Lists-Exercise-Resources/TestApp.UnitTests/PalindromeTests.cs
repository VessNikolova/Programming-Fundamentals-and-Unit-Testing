using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class PalindromeTests
{
    [Test]
    public void Test_IsPalindrome_ValidPalindrome_ReturnsTrue()
    {
        List<string> originalArr = new List<string> { "rotator", "deed", "noon" };

        bool actual = Palindrome.IsPalindrome(originalArr);

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_EmptyList_ReturnsTrue()
    {
        List<string> originalArr = new List<string> ();

        bool actual = Palindrome.IsPalindrome(originalArr);

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_SingleWord_ReturnsTrue()
    {
        List<string> originalArr = new List<string> { "deed" };

        bool actual = Palindrome.IsPalindrome(originalArr);

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsPalindrome_NonPalindrome_ReturnsFalse()
    {
        List<string> originalArr = new List<string> { "sofa", "computer", "flower" };

        bool actual = Palindrome.IsPalindrome(originalArr);

        Assert.That(actual, Is.False);
    }

    [Test]
    public void Test_IsPalindrome_MixedCasePalindrome_ReturnsTrue()
    {
        List<string> originalArr = new List<string> { "Level", "omO", "rAdar", "rEFer", "RAceCar" };

        bool actual = Palindrome.IsPalindrome(originalArr);

        Assert.That(actual, Is.True);
    }
}
