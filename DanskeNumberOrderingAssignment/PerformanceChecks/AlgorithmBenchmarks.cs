using BenchmarkDotNet.Attributes;
using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;

namespace DanskeNumberOrderingAssignment.PerformanceChecks;

[MemoryDiagnoser]
public class AlgorithmBenchmarks
{
    private int[] randomArray;
    private readonly IAlgorithm bubbleSort = new BubbleSort();
    private readonly IAlgorithm quickSort = new QuickSort();
    private readonly IAlgorithm mergeSort = new MergeSort();

    [GlobalSetup]
    public void Setup()
    {
        randomArray = GenerateRandomArray(10000);
    }

    private static int[] GenerateRandomArray(int size)
    {
        Random rand = new Random();
        return Enumerable.Range(0, size).Select(_ => rand.Next(1, 1000000)).ToArray();
    }

    [Benchmark]
    public void Benchmark_BubbleSort()
    {
        bubbleSort.Sort((int[])randomArray.Clone());
    }

    [Benchmark]
    public void Benchmark_QuickSort()
    {
        quickSort.Sort((int[])randomArray.Clone());
    }

    [Benchmark]
    public void Benchmark_MergeSort()
    {
        mergeSort.Sort((int[])randomArray.Clone());
    }
}