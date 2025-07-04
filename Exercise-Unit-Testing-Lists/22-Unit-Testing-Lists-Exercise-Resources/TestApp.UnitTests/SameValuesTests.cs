using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SameValuesTests
{
    [Test]
    public void Test_FindSameValues_EmptyFirstList_ReturnsEmptyList()
    {
        List<int> list1 = new List<int>();
        List<int> list2 = new List<int>() { 3, 5, 7, 4};

        List<int> actual = SameValues.FindSameValues(list1, list2);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_EmptySecondList_ReturnsEmptyList()
    {
        List<int> list1 = new List<int>() { 9, 1, 5, 7};
        List<int> list2 = new List<int>();

        List<int> actual = SameValues.FindSameValues(list1, list2);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_NoSameValuesInBothLists_ReturnsEmptyList()
    {
        List<int> list1 = new List<int>() { 2, 1, 9, 8 };
        List<int> list2 = new List<int>() { 3, 5, 7, 4 };

        List<int> actual = SameValues.FindSameValues(list1, list2);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_FindSameValues_BothListWithSameValues_ReturnsListWithSameValues()
    {
        List<int> list1 = new List<int>() { 3, 5, 7, 4 };
        List<int> list2 = new List<int>() { 3, 5, 7, 4 };

        List<int> actual = SameValues.FindSameValues(list1, list2);

        Assert.That(actual, Is.EqualTo(list1));
    }
}
