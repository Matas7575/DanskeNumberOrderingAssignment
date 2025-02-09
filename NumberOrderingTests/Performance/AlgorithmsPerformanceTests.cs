using System.Diagnostics;
using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;
using NumberOrderingTests.Utils;

namespace NumberOrderingTests.Performance;

/// <summary>
/// Test class to measure performance of sorting algorithms
/// This is just a simple example to show how to measure performance of algorithms and is not very accurate.
/// To increase accuracy and reliability, using BenchmarkDotNet is recommended.
/// (Reason why I did not use it is because I wanted to show how to do it with code without using libraries)
/// Repeating each test and then taking the average is also a good practice.
/// Testing with larger input sizes is also recommended to better analyze scaling behavior.
/// </summary>
[TestFixture]
public class AlgorithmsPerformanceTests
{
    private IAlgorithm _bubbleSort;
    private IAlgorithm _quickSort;
    private IAlgorithm _mergeSort;
    private int[] _smallArray;
    private int[] _largeArray;

    private static long MeasureExecutionTime(Action sortingAction)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        sortingAction.Invoke();
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
    
    [SetUp]
    public void Setup()
    {
        _bubbleSort = new BubbleSort();
        _quickSort = new QuickSort();
        _mergeSort = new MergeSort();
        _smallArray = GenerateRandomArray.Generate(10000);
        _largeArray = GenerateRandomArray.Generate(20000);
    }
    

    // Test to check if BubbleSort has O(n^2) time complexity
    [Test]
    public void BubbleSort_Performance_Test()
    {

        long timeSmall = MeasureExecutionTime(() => _bubbleSort.Sort(_smallArray));
        long timeLarge = MeasureExecutionTime(() => _bubbleSort.Sort(_largeArray));

        Console.WriteLine($"Bubble Sort - Small: {timeSmall} ms, Large: {timeLarge} ms");

        // Check if sorting time increases as expected (O(n^2) for Bubble Sort)
        Assert.That(timeLarge > timeSmall, "Larger input should take longer to sort.");
    }
    
    /*
     * Test to check if QuickSort has O(n log(n)) time complexity
     */
    [Test]
    public void QuickSort_Time_Complexity_Test()
    {

        long timeSmall = MeasureExecutionTime(() => _quickSort.Sort(_smallArray));
        long timeLarge = MeasureExecutionTime(() => _quickSort.Sort(_largeArray));

        Console.WriteLine($"Quick Sort - Small: {timeSmall} ms, Large: {timeLarge} ms");

        // Check if QuickSort has O(n log(n)) time complexity
        Assert.That(timeLarge >= timeSmall, "Larger input should take longer to sort.");
    }
    
    /*
     * Test to check if MergeSort has O(n log(n)) time complexity
     */
    [Test]
    public void MergeSort_Time_Complexity_Test()
    {

        long timeSmall = MeasureExecutionTime(() => _mergeSort.Sort(_smallArray));
        long timeLarge = MeasureExecutionTime(() => _mergeSort.Sort(_largeArray));

        Console.WriteLine($"Merge Sort - Small: {timeSmall} ms, Large: {timeLarge} ms");
        
        // Check if MergeSort has O(n log(n)) time complexity
        Assert.That(timeLarge > timeSmall, "Larger input should take longer to sort.");
    }
    
    // Test to compare sorting performance of BubbleSort, QuickSort, and MergeSort
    [Test]
    public void Compare_Sorting_Performance_Test()
    {
        long bubbleTime = MeasureExecutionTime(() => _bubbleSort.Sort((int[])_largeArray.Clone()));
        long quickTime = MeasureExecutionTime(() => _quickSort.Sort((int[])_largeArray.Clone()));
        long mergeTime = MeasureExecutionTime(() => _mergeSort.Sort((int[])_largeArray.Clone()));

        Console.WriteLine($"Bubble Sort: {bubbleTime} ms, Quick Sort: {quickTime} ms, Merge Sort: {mergeTime} ms");

        // QuickSort and MergeSort should be significantly faster than BubbleSort
        Assert.That(quickTime < bubbleTime / 10, "QuickSort should be at least 10x faster than BubbleSort.");
        Assert.That(mergeTime < bubbleTime / 10, "MergeSort should be at least 10x faster than BubbleSort.");
    }

}