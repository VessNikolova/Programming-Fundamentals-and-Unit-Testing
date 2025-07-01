using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class EvenLengthWordsFilterTests
{
    [Test]
    public void Test_GetEvenWords_InputArrayWithEmptyStrings_ShouldReturnEmptyString()
    {
        string[] arr = new string[] {};

        string expected = "";

        string result = EvenLengthWordsFilter.GetEvenWords(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneOddLengthWord_ShouldReturnEmptyString()
    {
        string[] arr = new string[] {"cat"};

        string expected = "";

        string result = EvenLengthWordsFilter.GetEvenWords(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayOnlyWithOddLengthWords_ShouldReturnEmptyString()
    {
        string[] arr = new string[] {"cat", "dog", "lemon", "flowers"};

        string expected = "";

        string result = EvenLengthWordsFilter.GetEvenWords(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithOneEvenLengthWord_ShouldReturnSameWord()
    {
        string[] arr = new string[] {"silver"};

        string expected = "silver";

        string result = EvenLengthWordsFilter.GetEvenWords(arr);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetEvenWords_InputArrayWithEvenAndOddLengthWords_ShouldReturnOnlyEvenLengthWords()
    {
        string[] arr = new string[] {"cat", "flower", "pen", "sofa", "laptop", "lemon"};

        string expected = "flower sofa laptop";

        string result = EvenLengthWordsFilter.GetEvenWords(arr);

        Assert.That(result, Is.EqualTo(expected));
    }
}

