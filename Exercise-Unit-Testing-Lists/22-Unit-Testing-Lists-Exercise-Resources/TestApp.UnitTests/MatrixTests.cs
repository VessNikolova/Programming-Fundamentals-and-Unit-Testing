using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        List<List<int>> expected = new() { new() { 6, 8 }, new() { 10, 12 } };

        // Act
        List<List<int>> actual = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        // Arrange
        List<List<int>> matrixA = new() { };
        List<List<int>> matrixB = new() { };
        List<List<int>> expected = new() { };

        // Act
        List<List<int>> actual = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 }, new() { 9, 10 } };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Matrix.MatrixAddition(matrixA, matrixB));
    }

    [Test]
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { -4, -1 }, new() { -3, -4 } };
        List<List<int>> matrixB = new() { new() { -7, -5 }, new() { -9, -2 } };
        List<List<int>> expected = new() { new() { -11, -6 }, new() { -12, -6 } };

        // Act
        List<List<int>> actual = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { -4, -1 }, new() { -3, -4 } };
        List<List<int>> matrixB = new() { new() { 0, 0 }, new() { 0, 0 } };
 

        // Act
        List<List<int>> actual = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(actual, Is.EqualTo(matrixA));
    }
}
