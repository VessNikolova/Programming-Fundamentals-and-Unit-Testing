using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListManipulationTests
{
    [Test]
    public void Test_RemoveNegativesAndReverse_EmptyListInput_ReturnEmptyList()
    {
        List<int> list = new List<int>();

        List<int> result = ListManipulation.RemoveNegativesAndReverse(list);

        Assert.That(result, Is.EqualTo(list));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyNegativeNumbers_ReturnEmptyList()
    {
        List<int> list = new List<int> { -2, -5, -8, -9};
        List<int> expected = new List<int>();

        List<int> result = ListManipulation.RemoveNegativesAndReverse(list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyOnePositiveNumber_ReturnSameCollection()
    {
        List<int> list = new List<int> { 2 };
        List<int> expected = new List<int>{ 2 };

        List<int> result = ListManipulation.RemoveNegativesAndReverse(list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_OnlyPositiveNumbers_ReturnRevursedList()
    {
        List<int> list = new List<int> { 2, 5, 8, 9, 7 };
        List<int> expected = new List<int> { 7, 9, 8, 5, 2};

        List<int> result = ListManipulation.RemoveNegativesAndReverse(list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_RemoveNegativesAndReverse_PostiveAndNegativeElements_ReturnPositiveNumbersInReversedOrder()
    {
        List<int> list = new List<int> { -2, 1, -5, 3, -8, 4, -9, 7 };
        List<int> expected = new List<int> { 7, 4, 3, 1};

        List<int> result = ListManipulation.RemoveNegativesAndReverse(list);

        Assert.That(result, Is.EqualTo(expected));
    }
}
