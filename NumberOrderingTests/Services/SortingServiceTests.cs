using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;
using DanskeNumberOrderingAssignment.Services;

namespace NumberOrderingTests.Services;

/// <summary>
/// This class contains tests for the SortingService class.
/// It might seem unnecessary to test the BubbleSort, MergeSort, and QuickSort methods since there already are tests for the algorithms themselves.
/// But it's important to test the SortingService class to ensure that the algorithms are being called correctly.
/// </summary>

[TestFixture]
public class SortingServiceTests
{
    private IAlgorithm _bubbleSort;
    private IAlgorithm _mergeSort;
    private IAlgorithm _quickSort;
    
    [SetUp]
    public void Setup()
    {
        _bubbleSort = new BubbleSort();
        _mergeSort = new MergeSort();
        _quickSort = new QuickSort();
    }
    
    [Test]
    public void BubbleSort_ShouldSortCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 8, 1, 3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { 1, 2, 3, 5, 8 };
        ISortingService sortingService = new SortingService();
        
        // Act
        sortingService.BubbleSort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void MergeSort_ShouldSortCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 8, 1, 3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { 1, 2, 3, 5, 8 };
        ISortingService sortingService = new SortingService();
        
        // Act
        sortingService.MergeSort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
    
    [Test]
    public void QuickSort_ShouldSortCorrectly()
    {
        // Arrange
        int[] input = { 5, 2, 8, 1, 3 };
        int[] expected = (int[])input.Clone(); // Preserve original
        int[] sorted = { 1, 2, 3, 5, 8 };
        ISortingService sortingService = new SortingService();
        
        // Act
        sortingService.QuickSort(input);
        
        // Assert
        Assert.That(input, Is.EqualTo(sorted));
        Assert.That(input, Is.Not.EqualTo(expected), "Input array should be modified in-place.");
    }
}