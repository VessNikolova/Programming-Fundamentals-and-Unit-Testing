using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MiddleCharactersTests
{
    [Test]
    public void Test_GetMiddleChars_EmptyString_ReturnsEmptyStringMessage()
    {
        string input = "";
        string expected = "Empty string";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_WhiteSpaceString_ReturnsEmptyStringMessage()
    {
        string input = " ";
        string expected = "Empty string";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_SingleCharacterString_ReturnsTheCharacter()
    {
        string input = "w";
        string expected = "w";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_EvenStringLength_ReturnsTwoCharactersString()
    {
        string input = "technology";
        string expected = "no";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMiddleChars_OddStringLength_ReturnsOneCharactersString()
    {
        string input = "console";
        string expected = "s";

        string actual = MiddleCharacters.GetMiddleChars(input);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
