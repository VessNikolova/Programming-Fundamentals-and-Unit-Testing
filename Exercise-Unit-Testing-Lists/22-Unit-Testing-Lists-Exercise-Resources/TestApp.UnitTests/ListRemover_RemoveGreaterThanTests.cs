using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveGreaterThanTests
{
    [Test]
    public void Test_RemoveElementsGreaterThan_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> list = new List<int>();
        int threshold = 5;

        List<int> actual = ListRemover.RemoveElementsGreaterThan(list, threshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithGreaterThanThresholdElements_ReturnsEmtyList()
    {
        List<int> list = new List<int>() { 4, 6, 8, 10 };
        int threshold = 3;

        List<int> actual = ListRemover.RemoveElementsGreaterThan(list, threshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanOrEqualToThresholdElements_ReturnsSameList()
    {
        List<int> list = new List<int>() { 4, 6, 8, 10 };
        int threshold = 11;

        List<int> actual = ListRemover.RemoveElementsGreaterThan(list, threshold);

        Assert.That(actual, Is.EqualTo(list));
    }

    [Test]
    public void Test_RemoveElementsGreaterThan_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyLessThanOrEqualToThreshold()
    {
        List<int> list = new List<int>() { 4, 6, 8, 10, 1, 9, 5, 3, 7 };
        int threshold = 7;

        List<int> expected = new List<int>() { 4, 6, 1, 5, 3, 7 };

        List<int> actual = ListRemover.RemoveElementsGreaterThan(list, threshold);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
