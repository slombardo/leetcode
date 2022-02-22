using System;
using System.Linq;

namespace leetcode.problems.MaximumAverageSubarrayI
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double runningTotal = nums.Take(k).Sum();
            var currentLargestAverage = runningTotal / k;

            for (var i = k; i < nums.Length; i++)
            {
                runningTotal -= nums[i - k];
                runningTotal += nums[i];
                currentLargestAverage = Math.Max(currentLargestAverage, runningTotal / k);
            }

            return currentLargestAverage;
        }
    }
}