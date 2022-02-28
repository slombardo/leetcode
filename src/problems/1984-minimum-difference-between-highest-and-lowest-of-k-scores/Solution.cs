using System;
using System.Linq;

namespace leetcode.problems.MinimumDifferenceBetweenHighestAndLowestOfKScores
{
    public class Solution
    {
        public int MinimumDifference(int[] nums, int k)
        {
            if (k <= 1) return 0;

            var sorted = nums.OrderBy(x => x).ToArray();
            var minimumDifference = int.MaxValue;

            for (var i = k - 1; i < sorted.Length; i++)
            {
                if (minimumDifference == 0) return 0;
                minimumDifference = Math.Min(minimumDifference, sorted[i] - sorted[i - k + 1]);
            }

            return minimumDifference;
        }
    }
}