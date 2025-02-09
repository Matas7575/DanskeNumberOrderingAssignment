namespace NumberOrderingTests;

using System.Collections.Generic;
using DanskeNumberOrderingAssignment.Services;
/// <summary>
/// This class contains a mock implementation of the ISortingService interface.
/// The sorting methods are faked and do not need to be implemented.
/// The algorithms themselves are tested in other tests.
/// </summary>
public class MockSortingService : ISortingService
{
    private string _fileContents;
    private readonly List<int[]> _sortedArrays = new();

    private int[] MockSort(int[] array)
    {
        // Fake the sorting logic
        var sortedArray = (int[])array.Clone();
        Array.Sort(sortedArray);
        _sortedArrays.Add(sortedArray);

        return sortedArray;
    }

    public int[] BubbleSort(int[] array)
    {
        return MockSort(array);
    }

    public int[] MergeSort(int[] array)
    {
        return MockSort(array);
    }

    public int[] QuickSort(int[] array)
    {
        return MockSort(array);
    }
}
