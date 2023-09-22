namespace Search.BinarySearch
{
    internal static class BinarySearch
    {
        public static (int, bool) Search(int[] hayStack, int needle)
        {
            int minValue = 0;
            int maxValue = hayStack.Length - 1;
            int iterations = 0;

            while (minValue < maxValue)
            {
                iterations++;

                int middleIndex = minValue + ((maxValue - minValue) / 2);
                int middleValue = hayStack[middleIndex];

                if (middleValue == needle)
                {
                    return (iterations, true);
                }
                else if (middleValue < needle)
                {
                    minValue = middleIndex + 1;
                }
                else
                {
                    maxValue = middleIndex;
                }
            }

            return (-1, false);
        }
    }
}
