using Xunit;

namespace Algorithms.Tests;

public class ArraysTests
{
    [Fact]
    public void IterativeBinarySearch_WhenArrayIsEmpty_ReturnsNegativeOne()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(-1, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayContainsOnlyTheValue_ReturnsZero()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { value };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfOddLengthDoesNotContainValue_ReturnsNegativeOne()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 7, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(-1, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfEvenLengthDoesNotContainValue_ReturnsNegativeOne()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 7, 7, 8, 11, 22, 300 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(-1, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfOddLengthContainsValueOnce_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 2, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(2, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfEvenLengthContainsValueOnce_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 2, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(2, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfOddLengthContainsValueAtStart_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { 2, 3, 7, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfOddLengthContainsValueAtEnd_ReturnsItsIndex()
    {
        // Arrange.
        int value = 300;
        var array = new int[] { -2, 1, 7, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(6, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfEvenLengthContainsValueAtStart_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { 2, 3, 7, 7, 8, 11, 300, 301 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void IterativeBinarySearch_WhenArrayOfEvenLengthContainsValueAtEnd_ReturnsItsIndex()
    {
        // Arrange.
        int value = 301;
        var array = new int[] { 2, 3, 7, 7, 8, 11, 300, 301 };

        // Act.
        int result = Arrays.IterativeBinarySearch(array, value);

        // Assert.
        Assert.Equal(7, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayIsEmpty_ReturnsNegativeOne()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(-1, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayContainsOnlyTheValue_ReturnsZero()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { value };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfOddLengthDoesNotContainValue_ReturnsNegativeOne()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 7, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(-1, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfEvenLengthDoesNotContainValue_ReturnsNegativeOne()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 7, 7, 8, 11, 22, 300 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(-1, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfOddLengthContainsValueOnce_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 2, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(2, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfEvenLengthContainsValueOnce_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { -2, 1, 2, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(2, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfOddLengthContainsValueAtStart_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { 2, 3, 7, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfOddLengthContainsValueAtEnd_ReturnsItsIndex()
    {
        // Arrange.
        int value = 300;
        var array = new int[] { -2, 1, 7, 7, 8, 11, 300 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(6, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfEvenLengthContainsValueAtStart_ReturnsItsIndex()
    {
        // Arrange.
        int value = 2;
        var array = new int[] { 2, 3, 7, 7, 8, 11, 300, 301 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(0, result);
    }

    [Fact]
    public void RecursiveBinarySearch_WhenArrayOfEvenLengthContainsValueAtEnd_ReturnsItsIndex()
    {
        // Arrange.
        int value = 301;
        var array = new int[] { 2, 3, 7, 7, 8, 11, 300, 301 };

        // Act.
        int result = Arrays.RecursiveBinarySearch(array, value);

        // Assert.
        Assert.Equal(7, result);
    }
}
