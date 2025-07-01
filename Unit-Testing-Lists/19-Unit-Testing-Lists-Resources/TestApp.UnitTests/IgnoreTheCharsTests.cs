using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class IgnoreTheCharsTests
{
    [Test]
    public void Test_IgnoreChars_EmptyStringSentence_ReturnsEmptyString()
    {
        List<char> list = new List<char> { 'a', 'i' };
        string sentence = "";
        string expected = string.Empty;

        string result = IgnoreTheChars.IgnoreChars(sentence, list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_EmptyList_ReturnsSameSentence()
    {
        List<char> list = new List<char>();
        string sentence = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.";
        string expected = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.";

        string result = IgnoreTheChars.IgnoreChars(sentence, list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_OneCharSentenceAndSameCharsForIgnoring_ReturnsEmptyString()
    {
        List<char> list = new List<char> { 'W' };
        string sentence = "W";
        string expected = "";

        string result = IgnoreTheChars.IgnoreChars(sentence, list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IgnoreChars_WholeSentenceAndFewCharsToIgnore_ReturnsCorrectString()
    {
        List<char> list = new List<char> { 'a', 'o', 'e' };
        string sentence = "We are what we repeatedly do. Excellence, then, is not an act, but a habit.";
        string expected = "W r wht w rptdly d. Excllnc, thn, is nt n ct, but  hbit.";

        string result = IgnoreTheChars.IgnoreChars(sentence, list);

        Assert.That(result, Is.EqualTo(expected));
    }
}
