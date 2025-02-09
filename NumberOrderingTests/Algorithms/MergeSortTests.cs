using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;
using NumberOrderingTests.Utils;

namespace NumberOrderingTests.Algorithms;
[TestFixture]
public class MergeSortTests
{
    private IAlgorithm _mergeSort;
    
    [SetUp]
    public void Setup()
    {
        _mergeSort = new MergeSort();
    }
    
    [Test]
    public void MergeSort_ShouldSortCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 8, 1, 3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { 1, 2, 3, 5, 8 };

        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void MergeSort_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expected = { };
        
        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting an empty array should return an empty array.");
    }
    
    [Test]
    public void MergeSort_ShouldHandleSingleElementArray()
    {
        // Arrange
        int[] input = { 5 };
        int[] expected = { 5 };
        
        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting a single element array should return the same array.");
    }
    
    [Test]
    public void MergeSort_ShouldHandleAlreadySortedArray()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5 };
        
        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting an already sorted array should return the same array.");
    }

    [Test]
    public void MergeSort_ShouldHandleDuplicates()
    {
        // Arrange
        int[] input = { 4, 2, 2, 8, 4, 5, 2, 8 };
        int[] expected = (int[])input.Clone();
        int[] sorted = { 2, 2, 2, 4, 4, 5, 8, 8 };
        
        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void MergeSort_ShouldHandleNegativeNumbers()
    {
        // Arrange
        int[] input = { -5, -2, -8, -1, -3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { -8, -5, -3, -2, -1 };
        
        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void MergeSort_ShouldHandleLargeArray()
    {
        // Arrange
        int[] input = GenerateRandomArray.Generate(10000);
        int[] expected = (int[])input.Clone(); // Preserve original
        Array.Sort(expected); // Use built-in sort for comparison
        
        // Act
        _mergeSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting a large array should return a sorted array.");
    }
}