using DanskeNumberOrderingAssignment.Interfaces;

namespace DanskeNumberOrderingAssignment.Algorithms;
/// <summary>
/// quick sort = moves smaller elements to left of a pivot.
/// recursively divide array in 2 partitions
///
/// run-time complexity = Best case O(n log(n))
///                       Average case O(n log(n))
///                       Worst case O(n^2) if already sorted
///
///  space complexity = O(log(n)) due to recursion
/// </summary>
public class QuickSort : IAlgorithm
{
    public void Sort(int[] array)
    {
        QSort(array, 0, array.Length - 1);
    }
    private static void QSort(int[] array, int start, int end)
    {
        if (end <= start) return; //base case
        int pivot = Partition(array, start, end);
        QSort(array, start, pivot - 1);
        QSort(array, pivot + 1, end);
    }
    private static int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int i = start - 1;

        int temp;
        for (int j = start; j <= end - 1; j++)
        {
            if (array[j] < pivot)
            {
                i++;
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        i++;
        temp = array[i];
        array[i] = array[end];
        array[end] = temp;
        return i;
    }
}