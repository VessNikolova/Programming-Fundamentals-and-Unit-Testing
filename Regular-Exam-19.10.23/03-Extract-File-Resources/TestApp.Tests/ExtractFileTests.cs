using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    { 

        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(null));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(string.Empty));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        string path = "C:\\Users\\John\\Documents\\example.txt";
        string expected = "File name: example\nFile extension: txt";

        string actual = ExtractFile.GetFile(path);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        string path = "C:\\Users\\John\\Documents\\example";
        string expected = "File name: example";

        string actual = ExtractFile.GetFile(path);

        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        string path = "C:\\Users\\John\\Documents?\\example.txt";
        string expected = "File name: example\nFile extension: txt";

        string actual = ExtractFile.GetFile(path);

        Assert.That(actual, Is.EqualTo(expected));
    }
}
