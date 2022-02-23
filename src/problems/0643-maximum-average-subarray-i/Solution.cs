using System;
using System.Linq;

namespace leetcode.problems.MaximumAverageSubarrayI
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            var runningTotal = nums.Take(k).Sum();
            var currentLargestSum = runningTotal;

            for (var i = k; i < nums.Length; i++)
            {
                runningTotal -= nums[i - k];
                runningTotal += nums[i];
                currentLargestSum = Math.Max(currentLargestSum, runningTotal);
            }

            return (double)currentLargestSum / k;
        }
    }
}