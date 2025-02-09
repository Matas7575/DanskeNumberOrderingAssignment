namespace DanskeNumberOrderingAssignment.Services;

public interface ISortingService
{
    int[] BubbleSort(int[] array);
    int[] MergeSort(int[] array);
    int[] QuickSort(int[] array);
}
