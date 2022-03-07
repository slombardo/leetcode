using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace leetcode.problems.TwoSum
{
    public class Solution {
        public int[] TwoSum(int[] nums, int target)
        {
            if (nums.Length == 2) return new[] {0, 1};

            var differenceSet = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var current = nums[i];
                if (differenceSet.TryGetValue(current, out var foundAt))
                {
                    return new[] {foundAt, i};
                }

                differenceSet[target - current] = i;
            }

            throw new ArgumentException("No solution available.");
        }
    }
}