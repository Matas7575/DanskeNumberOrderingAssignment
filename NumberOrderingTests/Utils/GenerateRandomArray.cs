namespace NumberOrderingTests.Utils;

public class GenerateRandomArray
{
    public static int[] Generate(int size)
    {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = rand.Next(1, 1000000); // Random numbers
        return arr;
    }
}