
using NUnit.Framework;

namespace TestApp.Tests;

public class PascalTriangleTests
{
    
   
    [TestCase(0,"")]
    [TestCase(2, "1 \n1 1 \n")]
    [TestCase(3, "1 \n1 1 \n1 2 1 \n")]
    [TestCase(4, "1 \n1 1 \n1 2 1 \n1 3 3 1 \n")]
    [TestCase(5, "1 \n1 1 \n1 2 1 \n1 3 3 1 \n1 4 6 4 1 \n")]
    public void Test_PrintTriangle_ShouldReturnCorrectString(int n, string expected)
    {
        string result = PascalTriangle.PrintTriangle(n);

        Assert.That(result, Is.EqualTo(expected));
    }
}
