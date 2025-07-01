using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class ListAnalyzerTests
{
    [Test]
    public void Test_Analyze_EmptyList_ShouldReturnNoElementsMsg()
    {
        List<int> list = new List<int>();
        string expected = "No elements!";

        string result = ListAnalyzer.Analyze(list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OneElement_ShouldReturnSameValueForMinMaxAvg()
    {
        List<int> list = new List<int> { 3 };
        string expected = "Element count: 1, Min value: 3, Max value: 3, Avg: 3.00.";

        string result = ListAnalyzer.Analyze(list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_OnlySameValueElements_ShouldReturnSameValueForMinMaxAvg()
    {
        List<int> list = new List<int> { 5, 5, 5, 5, 5 };
        string expected = "Element count: 5, Min value: 5, Max value: 5, Avg: 5.00.";

        string result = ListAnalyzer.Analyze(list);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Analyze_DiffrentValues_ShouldReturnCorrectValues()
    {
        List<int> list = new List<int> { 3, 7, 9, 1, 4, 6 };
        string expected = "Element count: 6, Min value: 1, Max value: 9, Avg: 5.00.";

        string result = ListAnalyzer.Analyze(list);

        Assert.That(result, Is.EqualTo(expected));
    }
}
