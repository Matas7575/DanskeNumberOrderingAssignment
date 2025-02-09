using DanskeNumberOrderingAssignment.Interfaces;

namespace DanskeNumberOrderingAssignment.Algorithms;
/// <summary>
/// bubble sort = pairs of adjacent elements are compared,
/// and the elements are swapped if they are not in order.
/// run-time complexity = O(n^2)
/// Space complexity = O(1)
/// Okay for small data sets
/// Bad for big data sets
/// </summary>
public class BubbleSort : IAlgorithm
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length -1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

