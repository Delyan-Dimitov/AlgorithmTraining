namespace Search.LinearSearch
{
    internal static class LinearSearch
    {
        public static (int, bool) Search(int[] hayStack, int needle)
        {
            for (int i = 0; i < hayStack.Length; i++)
            {
                if (hayStack[i] == needle)
                {
                    return (i + 1, true);
                }
            }
            return (-1, false);
        }
    }
}
