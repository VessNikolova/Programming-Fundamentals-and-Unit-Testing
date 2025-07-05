using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.Tests;

public class MessagingTests
{
    [Test]
    public void Test_GetMessage_WithValidInput_ReturnsExpectedMessage()
    {
        string str = "University";
        List<int> list = new List<int>() { 3, 5, 6 };

        string expected = "vst";

        string actual = Messaging.GetMessage(list, str);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMessage_EmptyList_ReturnsEmptyString()
    {
        string str = "The only true wisdom is in knowing you know nothing";
        List<int> list = new List<int>();

        string expected = "";

        string actual = Messaging.GetMessage(list, str);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMessage_EmptyString_ReturnsEmptyString()
    {
        string str = string.Empty;
        List<int> list = new List<int>() { 3, 5, 6, 10, 9 };

        string expected = "";

        string actual = Messaging.GetMessage(list, str);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMessage_NullList_ReturnsEmptyString()
    {
        string str = "University";

        string expected = "";

        string actual = Messaging.GetMessage(null, str);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetMessage_NullString_ReturnsEmptyString()
    {
        List<int> list = new List<int>() { 3, 5, 6 };

        string expected = "";

        string actual = Messaging.GetMessage(list, null);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
