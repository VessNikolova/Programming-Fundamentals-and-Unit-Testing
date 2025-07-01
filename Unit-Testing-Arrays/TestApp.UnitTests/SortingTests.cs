using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SortingTests
{
    [Test]
    public void Test_ShallowAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        double[] arr = Array.Empty<double> ();
      
        double[] result = Sorting.ShallowAscendingSort(arr);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_DeepAscendingSort_EmptyArrayParameter_ReturnsEmptyArray()
    {
        double[] arr = Array.Empty<double>();

        double[] result = Sorting.DeepAscendingSort(arr);

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_ShallowAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesNotChangeTheOriginalArray()
    {
        double[] arr = {5, 1.4, 7.8, 3.7, 9.1, 2.13};

        double[] expected = {1.4, 2.13, 3.7, 5, 7.8, 9.1};

        double[] result = Sorting.ShallowAscendingSort(arr);

        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Is.Not.EqualTo(arr));
    }

    [Test]
    public void Test_DeepAscendingSort_UnOrderedArrayParam_ReturnsAscendingOrderedArrayAndDoesChangeTheOriginalArray()
    {
        double[] arr = { 5, 1.4, 7.8, 3.7, 9.1, 2.13 };

        double[] expected = { 1.4, 2.13, 3.7, 5, 7.8, 9.1 };

        double[] result = Sorting.DeepAscendingSort(arr);

        Assert.That(result, Is.EqualTo(expected));
        Assert.That(result, Is.EqualTo(arr));
    }
}
