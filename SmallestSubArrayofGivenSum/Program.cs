using System;

namespace SmallestSubArrayofGivenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var subArray = SmallestSubArray(new int[] {3, 4, 1, 1, 6}, 8);
            Console.WriteLine(subArray);
        }

        private static int SmallestSubArray(int[] array, int S)
        {
            //Start by increasing the windowsum to meet the required criteria
            int windowStart = 0, subArray = Int32.MaxValue, windowSum = 0;

            for (int windowEnd = 0; windowEnd < array.Length; windowEnd++)
            {
                windowSum += array[windowEnd]; //increase windowsum
                
                while (windowSum >= S) //drop in here when windowsum meets threshold
                {
                    //check if subarray(min length) is the smallest otherwise get smallest from window tracker
                    subArray = subArray < (windowEnd - windowStart + 1) ? subArray : windowEnd - windowStart + 1;
                    windowSum -= array[windowStart]; //reduce windowsize, will drop out of while when window is too small
                    windowStart++; //shift window
                }
            }
            return subArray == -1 ? 0 : subArray; //return 0 if no minimum was found or the actual min
        }
    }
}
