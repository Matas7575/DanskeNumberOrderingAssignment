using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;
using NumberOrderingTests.Utils;

namespace NumberOrderingTests.Algorithms;

public class QuickSortTests
{
    private IAlgorithm _quickSort;
    
    [SetUp]
    public void Setup()
    {
        _quickSort = new QuickSort();
    }
    
    [Test]
    public void QuickSort_ShouldSortCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 8, 1, 3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { 1, 2, 3, 5, 8 };

        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void QuickSort_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expected = { };
        
        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting an empty array should return an empty array.");
    }
    
    [Test]
    public void QuickSort_ShouldHandleSingleElementArray()
    {
        // Arrange
        int[] input = { 5 };
        int[] expected = { 5 };
        
        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting a single element array should return the same array.");
    }
    
    [Test]
    public void QuickSort_ShouldHandleAlreadySortedArray()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = (int[])input.Clone(); // Preserve original
        
        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting an already sorted array should return the same array.");
    }

    [Test]
    public void QuickSort_ShouldHandleDuplicates()
    {
        // Arrange
        int[] input = { 4, 2, 2, 8, 4, 5, 2, 8 };
        int[] expected = (int[])input.Clone();
        int[] sorted = { 2, 2, 2, 4, 4, 5, 8, 8 };
        
        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void QuickSort_ShouldHandleNegativeNumbers()
    {
        // Arrange
        int[] input = { -5, -2, -8, -1, -3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { -8, -5, -3, -2, -1 };
        
        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void QuickSort_ShouldHandleLargeArray()
    {
        // Arrange
        int[] input = GenerateRandomArray.Generate(10000);
        int[] expected = (int[])input.Clone(); // Preserve original
        
        // Act
        _quickSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    
}