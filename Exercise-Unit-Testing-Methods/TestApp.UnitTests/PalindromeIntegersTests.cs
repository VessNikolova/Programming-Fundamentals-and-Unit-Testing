using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class PalindromeIntegersTests
{
    private PalindromeIntegers palindromeIntegers;

    [SetUp]
    public void TestInitialize()
    {
       palindromeIntegers = new PalindromeIntegers();
    }

    [Test]
    public void Test_FindPalindromes_EmptyList_ReturnsEmptyList()
    {
        List<int> numbers = new List<int>();
        List<int> expected = new List<int>();

        List<int> actual = palindromeIntegers.FindPalindromes(numbers);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_NoPalindromes_ReturnsEmptyList()
    {
        List<int> numbers = new List<int>() { 32, 56, 6834, 9582, 112};
        List<int> expected = new List<int>();

        List<int> actual = palindromeIntegers.FindPalindromes(numbers);

        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_FindPalindromes_OnlySingleDigitsElements_ReturnsSameIntegersList()
    {
        List<int> numbers = new List<int>() { 9, 6, 4, 5, 1 };

        List<int> actual = palindromeIntegers.FindPalindromes(numbers);

        CollectionAssert.AreEqual(numbers, actual);
    }

    [Test]
    public void Test_FindPalindromes_AllElementsArePalindromes_ReturnsSameIntegersList()
    {
        List<int> numbers = new List<int>() { 323, 5665, 6886, 9559, 11211 };

        List<int> actual = palindromeIntegers.FindPalindromes(numbers);

        CollectionAssert.AreEqual(numbers, actual);
    }

    [Test]
    public void Test_FindPalindromes_PalimdromesAndNoPalindromesIntegers_ReturnsOnlyPalindromes()
    {
        List<int> numbers = new List<int>() { 323, 566655, 6886, 37834534, 11211, 39487534 };
        List<int> expected = new List<int>() { 323, 6886, 11211 };

        List<int> actual = palindromeIntegers.FindPalindromes(numbers);

        CollectionAssert.AreEqual(expected, actual);
    }
}
