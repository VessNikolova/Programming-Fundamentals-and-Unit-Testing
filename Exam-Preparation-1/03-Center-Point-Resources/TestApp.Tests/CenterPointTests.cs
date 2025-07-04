using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        double x1 = 3;
        double y1 = 5;
        double x2 = 6;
        double y2 = 9;
        string expected = "(3, 5)";

        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        double x1 = 9;
        double y1 = 8;
        double x2 = 3;
        double y2 = 4;
        string expected = "(3, 4)";

        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        double x1 = 3;
        double y1 = 5;
        double x2 = 5;
        double y2 = 3;
        string expected = "(3, 5)";

        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        double x1 = -1;
        double y1 = -1;
        double x2 = 1;
        double y2 = 1;
        string expected = "(-1, -1)";

        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        double x1 = 3;
        double y1 = 1;
        double x2 = 3;
        double y2 = -1;
        string expected = "(3, -1)";

        string actual = CenterPoint.GetClosest(x1, y1, x2, y2);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
