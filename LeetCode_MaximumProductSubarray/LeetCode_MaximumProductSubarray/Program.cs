/*
https://leetcode.com/problems/maximum-product-subarray/

Given an integer array nums, find a contiguous non-empty subarray within the array that has the largest product, and return the product.

The test cases are generated so that the answer will fit in a 32-bit integer.

A subarray is a contiguous subsequence of the array.

 

Example 1:

Input: nums = [2,3,-2,4]
Output: 6
Explanation: [2,3] has the largest product 6.
Example 2:

Input: nums = [-2,0,-1]
Output: 0
Explanation: The result cannot be 2, because [-2,-1] is not a subarray.

 */
namespace LeetCode_MaximumProductSubarray
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(MaxProduct(new int[] { 2, 3, -2, 4 }));
            Console.WriteLine(MaxProduct(new int[] { -2, 0, -1 }));
            Console.WriteLine(MaxProduct(new int[] { -3, -1, -1 }));
            Console.WriteLine(MaxProduct(new int[] { 0, 2 }));
            Console.WriteLine(MaxProduct(new int[] { 7, -2, -4 }));
        }

        public static int MaxProduct(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int maxProduct = 1;
            int minProduct = 1;
            int result = nums.Max();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    maxProduct = 1;
                    minProduct = 1;
                    continue;
                }

                int tempMax = nums[i] * maxProduct;
                maxProduct = Math.Max(Math.Max(tempMax, nums[i] * minProduct), nums[i]);
                minProduct = Math.Min(Math.Min(tempMax, nums[i] * minProduct), nums[i]);

                result = Math.Max(result, maxProduct);
            }

            return result;
        }
    }
}