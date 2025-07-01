using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        int input = 0;

        String result = Triangle.PrintTriangle(input);

        Assert.That(result, Is.EqualTo(""));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        int input = 3;

        String result = Triangle.PrintTriangle(input);

        string expected = $"1{Environment.NewLine}1 2{Environment.NewLine}" +
            $"1 2 3{Environment.NewLine}1 2{Environment.NewLine}1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        int input = 5;

        String result = Triangle.PrintTriangle(input);

        string expected = $"1{Environment.NewLine}1 2{Environment.NewLine}1 2 3{Environment.NewLine}1 2 3 4" +
            $"{Environment.NewLine}1 2 3 4 5{Environment.NewLine}1 2 3 4{Environment.NewLine}1 2 3" +
            $"{Environment.NewLine}1 2{Environment.NewLine}1";

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_NegativeSize()
    {
        int input = -5;

        String result = Triangle.PrintTriangle(input);

        string expected = "";

        Assert.That(result, Is.EqualTo(expected));
    }
}
