using NUnit.Framework;
using System;

using System.Collections.Generic;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        decimal price = 10.5m;
        List<int> quality = new List<int> { 2, 5, 6, 7 };
        List<string> commands = new List<string>();

        Assert.Throws<ArgumentException>(() => DrumSet.Drum(price, quality, commands));
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        decimal price = 10.5m;
        List<int> quality = new List<int> { 2, 5, 6, 7 };
        List<string> commands = new List<string> { "No command", "End"};

        Assert.Throws<ArgumentException>(() => DrumSet.Drum(price, quality, commands));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        decimal price = 10.5m;
        List<int> quality = new List<int> { 2, 5, 6, 7 };
        List<string> commands = new List<string> { "2", "Hit it again, Gabsy!" };

        string expected = "2 3 4 5\nGabsy has 4.50lv.";

        string actual = DrumSet.Drum(price, quality, commands);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 15.0m;
        List<int> initialQuality = new List<int> { 5, 5 };
        List<string> commands = new List<string> { "5", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 15.00lv.";

        string actual = DrumSet.Drum(money, initialQuality, commands);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 3.0m;
        List<int> initialQuality = new List<int> { 4, 6 };
        List<string> commands = new List<string> { "4", "3", "Hit it again, Gabsy!" };

        string expected = "\nGabsy has 3.00lv.";

        string actual = DrumSet.Drum(money, initialQuality, commands);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
