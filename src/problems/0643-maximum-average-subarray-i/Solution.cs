namespace leetcode.problems.MaximumAverageSubarrayI
{
    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double? currentLargestAverage = null;
            double runningTotal = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                runningTotal += nums[i];
                if (i < k - 1) continue;
                if (i >= k) runningTotal -= nums[i - (k)];

                var average = runningTotal / k;
                if (!currentLargestAverage.HasValue || currentLargestAverage < average) currentLargestAverage = average;
            }

            return currentLargestAverage ?? 0;
        }
    }
}