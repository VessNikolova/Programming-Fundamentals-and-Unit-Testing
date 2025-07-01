using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class AverageGradeTests
{
    [Test]
    public void Test_GetGradeDefinition_AverageGradeUnderTwo_ReturnsErrorMessage()
    {
        List<double> grades = new List<double> { 1.5, 1.6, 1.99 };
        string expected = "Incorrect grades";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_AverageGradeOverSix_ReturnsErrorMessage()
    {
        List<double> grades = new List<double> { 6.5, 7.6, 8.99 };
        string expected = "Incorrect grades";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_FailScoreAverageGrade_ReturnsFailDefinitionMessage()
    {
        List<double> grades = new List<double> { 2.5, 2.0, 3.55 };
        string expected = "Fail";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_PoorScoreAverageGrade_ReturnsPoorDefinitionMessage()
    {
        List<double> grades = new List<double> { 2.8, 3.99, 3.30 };
        string expected = "Poor";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_GoodScoreAverageGrade_ReturnsGoodDefinitionMessage()
    {
        List<double> grades = new List<double> { 3.5, 4.90, 4.75 };
        string expected = "Good";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_VeryGoodScoreAverageGrade_ReturnsVeryGoodDefinitionMessage()
    {
        List<double> grades = new List<double> { 4.57, 5.49, 5.25 };
        string expected = "Very good";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetGradeDefinition_ExcellentScoreAverageGrade_ReturnsExcellentDefinitionMessage()
    {
        List<double> grades = new List<double> { 5.1, 5.95, 5.72 };
        string expected = "Excellent";

        string actual = AverageGrade.GetGradeDefinition(grades);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
