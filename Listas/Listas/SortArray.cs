namespace Listas;

public static class SortArray
{
    public static int[] Exec(int[] array)
    {
        for (int i = array.Length; i > 0; i--)
        {
            for (int j = 0; j < i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    var temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
}
