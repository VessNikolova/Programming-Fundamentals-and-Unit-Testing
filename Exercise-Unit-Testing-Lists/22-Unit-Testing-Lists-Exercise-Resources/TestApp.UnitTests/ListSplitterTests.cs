using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListSplitterTests
{
    [Test]
    public void Test_SplitEvenAndOdd_EmptyListParameter_ReturnsEmptyEvenAndOddLists()
    {
        List<int> list = new();

        (List<int> even, List<int> odd) actual = ListSplitter.SplitEvenAndOdd(list);

        Assert.That(actual.even, Is.Empty);
        Assert.That(actual.odd, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyEvenValues_ReturnsEmptyOddList()
    {
        List<int> list = new List<int> { 8, 2, 4, 6, 14 };


        (List<int> even, List<int> odd) actual = ListSplitter.SplitEvenAndOdd(list);

        Assert.That(actual.even, Is.EquivalentTo(list));
        Assert.That(actual.odd, Is.Empty);
    }

    [Test]
    public void Test_SplitEvenAndOdd_OnlyOddValues_ReturnsEmptyEvenList()
    {
        List<int> list = new List<int> { 3, 5, 9, 1, 13, 23 };

        (List<int> even, List<int> odd) actual = ListSplitter.SplitEvenAndOdd(list);

        Assert.That(actual.even, Is.Empty);
        Assert.That(actual.odd, Is.EquivalentTo(list));
    }

    [Test]
    public void Test_SplitEvenAndOdd_EvenAndOddValues_ReturnsListWithCorrectValues()
    {
        List<int> list = new List<int> { 3, 5, 9, 1, 7, 4, 6 };

        List<int> even = new() { 4, 6 };
        List<int> odd = new() { 3, 5, 9, 1, 7 };

        (List<int> even, List<int> odd) actual = ListSplitter.SplitEvenAndOdd(list);

        Assert.That(actual.even, Is.EquivalentTo(even));
        Assert.That(actual.odd, Is.EquivalentTo(odd));
    }
}

