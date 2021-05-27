using System;

namespace MaxSumSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {2, 3, 4, 1, 5};
            var K = 2;
            var result = MaxContigousSum(K, numbers);
            Console.WriteLine(result);
        }

        public static int MaxContigousSum(int K, int[] numbers)
        {
            int windowSum = 0, //Keeps track of the sum of elements in sliding window
             windowStart = 0,  //Keeps track of the first element in the window
             maxSum = 0;       //Keeps track of the largest sum found until the end
            for (int windowEnd = 0; windowEnd < numbers.Length; windowEnd++) //Keeps track of end of window
            {
                windowSum += numbers[windowEnd]; //adds the next element to the window
                if(windowEnd >= K - 1) //only proceed when the sliding window has k elements
                {
                    maxSum = windowSum > maxSum ? windowSum : maxSum; //compare current window sum and max so far, pick the highest
                    windowSum -= numbers[windowStart]; //Moves the sliding window forward
                    windowStart++;                     //Tracks the new start of the window
                }
            }
            return maxSum; //result
        }
    }
}
