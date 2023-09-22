namespace Sorting.BubbleSort
{
    internal static class BubbleSort
    {
        public static void Sort(int[] array)
        {
            var length = array.Length;
            while (length > 1)
            {
                for (int i = 0; i < length -1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                    }
                }
                length--;
            }
        }
    }
}
