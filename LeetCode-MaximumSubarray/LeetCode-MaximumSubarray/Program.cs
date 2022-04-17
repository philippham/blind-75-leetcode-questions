namespace LeetCode_MaximumSubarray
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(MaxSubArray(new int[] { -2, -1 }));
            Console.WriteLine(MaxSubArray(new int[] {-2, 1, -3, 4, -1, 2, 1, -5, 4 }));
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.Length == 1) {
                return nums[0];
            }

            int maxSum = int.MinValue;
            int runningSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                runningSum += nums[i];
                maxSum = Math.Max(maxSum, runningSum);

                if (runningSum < 0)
                {
                    runningSum = 0;
                }
            }

            return maxSum;
        } 
    }
}