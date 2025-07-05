using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        char a = 'A';
        char b = 'B';

        string expected = "";

        string actual = CharacterRange.GetRange(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        char a = 'B';
        char b = 'A';

        string expected = "";

        string actual = CharacterRange.GetRange(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        char a = 'A';
        char b = 'C';

        string expected = "B";

        string actual = CharacterRange.GetRange(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        char a = 'D';
        char b = 'G';

        string expected = "E F";

        string actual = CharacterRange.GetRange(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        char a = 'X';
        char b = 'Z';

        string expected = "Y";

        string actual = CharacterRange.GetRange(a, b);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
