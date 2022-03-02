using System;

namespace leetcode.problems.MaximumSubarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            var currentMax = int.MinValue;
            var runningTotal = 0;

            foreach (var current in nums)
            {
                if (runningTotal + current < current) runningTotal = 0;
                runningTotal += current;
                currentMax = Math.Max(currentMax, runningTotal);
            }

            return currentMax;
        }
    }
}