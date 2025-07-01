using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class FakeTests
{
    [Test]
    public void Test_RemoveStringNumbers_RemovesDigitsFromCharArray()
    {
        char[] chars = new char[] { '1', 'w', 'r', '4', '5', 'u' };
        char[] expectedChars = new char[] { 'w', 'r', 'u' };

        char[] actualChars = Fake.RemoveStringNumbers(chars);

        Assert.That(actualChars, Is.EqualTo(expectedChars));
    }

    [TestCase(new char[] { 'k', 'w', 'r', 'c', 'm', 'u' })]
    [TestCase(new char[] { '#', '|', '$', '%', '^', '-' })]
    [TestCase(new char[] { 'k', '>', '=', ':', ';', 'u' })]
    public void Test_RemoveStringNumbers_NoDigitsInInput_ReturnsSameArray(char[] chars)
    {

        char[] actualChars = Fake.RemoveStringNumbers(chars);

        CollectionAssert.AreEqual(chars, actualChars);
    }

    [Test]
    public void Test_RemoveStringNumbers_EmptyArray_ReturnsEmptyArray()
    {
        char[] chars = Array.Empty<char>();
        char[] expectedChars = Array.Empty<char>();

        char[] actualChars = Fake.RemoveStringNumbers(chars);

        Assert.That(actualChars, Is.EqualTo(expectedChars));
    }
}
