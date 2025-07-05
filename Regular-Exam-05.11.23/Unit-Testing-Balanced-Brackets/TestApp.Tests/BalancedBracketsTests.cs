using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class BalancedBracketsTests
{
    [Test]
    public void Test_IsBalanced_EmptyInput_ShouldReturnTrue()
    {
        string[] arr = Array.Empty<string>();

        bool actual = BalancedBrackets.IsBalanced(arr);

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsBalanced_BalancedBrackets_ShouldReturnTrue()
    {
        string[] arr = new string[] { "(", ")", "(", ")" };

        bool actual = BalancedBrackets.IsBalanced(arr);

        Assert.That(actual, Is.True);
    }

    [Test]
    public void Test_IsBalanced_UnbalancedBrackets_ShouldReturnFalse()
    {
        string[] arr = new string[] { "(", ")", "(", ")", ")" };

        bool actual = BalancedBrackets.IsBalanced(arr);

        Assert.That(actual, Is.False);
    }

    [Test]
    public void Test_IsBalanced_MoreClosingBrackets_ShouldReturnFalse()
    {
        string[] arr = new string[] { "(", ")", "(", ")", ")", ")", ")"};

        bool actual = BalancedBrackets.IsBalanced(arr);

        Assert.That(actual, Is.False);
    }

    [Test]
    public void Test_IsBalanced_NoClosingBrackets_ShouldReturnFalse()
    {
        string[] arr = new string[] { "(", "(", "(", "(", "(", "(", "(" };

        bool actual = BalancedBrackets.IsBalanced(arr);

        Assert.That(actual, Is.False);
    }
}
