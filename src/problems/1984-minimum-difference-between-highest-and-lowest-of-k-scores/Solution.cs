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
            var window = sorted[..k];
            var minimumDifference = window[k - 1] - window[0];

            for (var i = k; i < sorted.Length; i++)
            {
                if (minimumDifference == 0) return 0;

                var firstIndex = i - k + 1;
                window = sorted[firstIndex..(i + 1)];
                minimumDifference = Math.Min(minimumDifference, window[k - 1] - window[0]);
            }

            return minimumDifference;
        }
    }
}