namespace MergeArrays;

public class Program
{
    public static void Main(string[] args)
    {
        int[] a1 = { 1, 3, 5 };
        int[] a2 = { 2, 4, 6 };
        int[] merged = MergeSortedArrays(a1, a2);
        Console.WriteLine(string.Join(", ", merged));
    }

    // TODO 
    public static int[] MergeSortedArrays(int[] array1, int[] array2)
    {
        if (array1 == null || array1.Length == 0)
            return array2 ?? Array.Empty<int>();
        if (array2 == null || array2.Length == 0)
            return array1 ?? Array.Empty<int>();

        int[] merged = new int[array1.Length + array2.Length];
        int i = 0, j = 0, k = 0;

        while (i < array1.Length && j < array2.Length)
        {
            if (array1[i] <= array2[j])
                merged[k++] = array1[i++];
            else
                merged[k++] = array2[j++];
        }

        while (i < array1.Length)
            merged[k++] = array1[i++];
        while (j < array2.Length)
            merged[k++] = array2[j++];

        return merged;
    }

    // TODO 
    private static bool IsSorted(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
                return false;
        }
        return true;
    }
}
