using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;
using NumberOrderingTests.Utils;

namespace NumberOrderingTests.Algorithms;
[TestFixture]
public class BubbleSortTests
{
    private IAlgorithm _bubbleSort;
    
    [SetUp]
    public void Setup()
    {
        _bubbleSort = new BubbleSort();
    }
    
    [Test]
    public void BubbleSort_ShouldSortCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 8, 1, 3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { 1, 2, 3, 5, 8 };

        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void BubbleSort_ShouldHandleEmptyArray()
    {
        // Arrange
        int[] input = { };
        int[] expected = { };
        
        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting an empty array should return an empty array.");
    }
    
    [Test]
    public void BubbleSort_ShouldHandleSingleElementArray()
    {
        // Arrange
        int[] input = { 5 };
        int[] expected = { 5 };
        
        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting a single element array should return the same array.");
    }
    
    [Test]
    public void BubbleSort_ShouldHandleAlreadySortedArray()
    {
        // Arrange
        int[] input = { 1, 2, 3, 4, 5 };
        int[] expected = { 1, 2, 3, 4, 5 };
        
        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting an already sorted array should return the same array.");
    }
    
    [Test]
    public void BubbleSort_ShouldHandleDuplicates()
    {
        // Arrange
        int[] input = { 4, 2, 2, 8, 4, 5, 2, 8 };
        int[] expected = (int[])input.Clone();
        int[] sorted = { 2, 2, 2, 4, 4, 5, 8, 8 };
        
        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Array with duplicates should put duplicates next to each other.");
    }
    
    [Test]
    public void BubbleSort_ShouldHandleNegativeNumbers()
    {
        // Arrange
        int[] input = { -5, -2, -8, -1, -3 };
        int[] expected = (int[])input.Clone();
        int[] sorted = { -8, -5, -3, -2, -1 };
        
        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Array with negative numbers should be sorted correctly.");
    }
    
    [Test]
    public void BubbleSort_ShouldHandleLargeArray()
    {
        // Arrange
        int[] input = GenerateRandomArray.Generate(10000);
        int[] expected = (int[])input.Clone();
        Array.Sort(expected);
        
        
        // Act
        _bubbleSort.Sort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(expected), "Sorting a large array should work correctly.");
    }
}