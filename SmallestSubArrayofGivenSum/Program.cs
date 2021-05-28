using System;

namespace SmallestSubArrayofGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var subArray = SmallestSubArray(new int[] {2, 1, 5, 2, 3, 2}, 7);
            Console.WriteLine(subArray);
        }

        private static int SmallestSubArray(int[] array, int S)
        {
            int windowStart = 0, subArray = 0, windowSum = 0;

            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                windowSum += array[windowEnd];
                subArray++;
                
                if(windowSum >= S)
                    return subArray;
            }
            return 0;
        }
    }
}
