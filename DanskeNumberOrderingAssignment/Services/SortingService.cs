using DanskeNumberOrderingAssignment.Algorithms;
using DanskeNumberOrderingAssignment.Interfaces;
namespace DanskeNumberOrderingAssignment.Services;

public class SortingService : ISortingService
{
    private readonly IAlgorithm _bubbleSort;
    private readonly IAlgorithm _mergeSort;
    private readonly IAlgorithm _quickSort;
    
    public SortingService()
    {
        _bubbleSort = new BubbleSort();
        _mergeSort = new MergeSort();
        _quickSort = new QuickSort();
    }

    public int[] BubbleSort(int[] array)
    {
        _bubbleSort.Sort(array);
        
        return array;
    }

    public int[] MergeSort(int[] array)
    {
        _mergeSort.Sort(array);
        
        return array;
    }

    public int[] QuickSort(int[] array)
    {
        _quickSort.Sort(array);
        
        return array;
    }
}
