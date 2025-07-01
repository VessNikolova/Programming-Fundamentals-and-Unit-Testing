using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SignOfIntegerNumbersTests
{
    [TestCase("Fish")]
    [TestCase("Code")]
    [TestCase("Tree")]
    [TestCase("Flower")]
    public void Test_CheckSign_NotAnIntegerValue_ReturnErrorMessage(string number)
    {
        string expected = "The input is not an integer!";

        string result = SignOfIntegerNumbers.CheckSign(number);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CheckSign_ZeroValueInput_ReturnMessageForZero()
    {
        string number = "0";
        string expected = "The number 0 is zero.";

        string result = SignOfIntegerNumbers.CheckSign(number);

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("-124", "The number -124 is negative.")]
    [TestCase("-5", "The number -5 is negative.")]
    [TestCase("-56754", "The number -56754 is negative.")]
    [TestCase("-144", "The number -144 is negative.")]
    public void Test_CheckSign_NegativeValueInput_ReturnMessageForNegativeInteger(string number, string expected)
    {

        string result = SignOfIntegerNumbers.CheckSign(number);

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase("124", "The number 124 is positive.")]
    [TestCase("24", "The number 24 is positive.")]
    [TestCase("56754", "The number 56754 is positive.")]
    [TestCase("857", "The number 857 is positive.")]
    public void Test_CheckSign_PositiveValueInput_ReturnMessageForPositiveInteger(string number, string expected)
    {

        string result = SignOfIntegerNumbers.CheckSign(number);

        Assert.That(result, Is.EqualTo(expected));
    }
}
