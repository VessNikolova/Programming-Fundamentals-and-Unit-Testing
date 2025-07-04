using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListRemover_RemoveLessThanOrEqualToTests
{
    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_EmptyListParameter_ReturnsEmtyList()
    {
        List<int> list = new List<int>();
        int threshold = 3;

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(list, threshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanOrEqualToThresholdElements_ReturnsEmtyList()
    {
        List<int> list = new List<int>() { 4, 6, 8, 10 };
        int threshold = 11;

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(list, threshold);

        Assert.That(actual, Is.Empty);
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithOnlyGreaterThanThresholdElements_ReturnsSameList()
    {
        List<int> list = new List<int>() { 4, 6, 8, 10 };
        int threshold = 3;

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(list, threshold);

        Assert.That(actual, Is.EqualTo(list));
    }

    [Test]
    public void Test_RemoveElementsLessThanOrEqualTo_ListWithLessThanEqualAndGreaterThanThresholdElements_ReturnsOnlyGreaterThanThreshold()
    {
        List<int> list = new List<int>() { 4, 6, 8, 10, 1, 3, 9 };
        int threshold = 7;

        List<int> expected = new List<int>() { 8, 10, 9 };

        List<int> actual = ListRemover.RemoveElementsLessThanOrEqualTo(list, threshold);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
