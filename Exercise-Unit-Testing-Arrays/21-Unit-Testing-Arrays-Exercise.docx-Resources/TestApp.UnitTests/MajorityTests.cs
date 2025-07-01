using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class MajorityTests
{
    [Test]
    public void Test_IsEvenOrOddMajority_EmpryArray_ReturnsZero()
    {
        int[] originalArr = new int[0];
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_ArrayOnlyWithZeros_ReturnsZero()
    {
        int[] originalArr = new int[] {0, 0, 0, 0, 0, 0};
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EqualOddAndEvenNumbers_ReturnsZero()
    {
        int[] originalArr = new int[] {5, 3, 4, 1, 9, 6, 12, 20 };
        int expected = 0;

        int actual = Majority.IsEvenOrOddMajority(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_EvenMajority_ReturnsPositiveNumber()
    {
        int[] originalArr = new int[] { 5, 3, 4, 1, 9, 6, 12, 20, 2, 8 };
        int expected = 2;

        int actual = Majority.IsEvenOrOddMajority(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_IsEvenOrOddMajority_OddMajority_ReturnsNegativeNumber()
    {
        int[] originalArr = new int[] { 5, 3, 4, 1, 9, 6, 12, 20, 7, 11, 15, 9 };
        int expected = -4;

        int actual = Majority.IsEvenOrOddMajority(originalArr);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
