using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework.Constraints;

namespace leetcode.problems.MajorityElement
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var sorted = nums.OrderBy(x => x).ToArray();
            return sorted[sorted.Length / 2];
        }
    }

    public class Solution2
    {
        public int MajorityElement(int[] nums)
        {
            var counts = new Dictionary<int, int>();
            var halfway = nums.Length / 2;

            foreach (var number in nums)
            {
                var count = counts.GetValueOrDefault(number) + 1;
                if (count > halfway) return number;

                counts[number] = count;
            }

            throw new ArgumentException($"{nameof(nums)} does not have a majority.");
        }
    }
    public class Solution3
    {
        public int MajorityElement(int[] nums)
        {
            var current = -1;
            var count = 0;

            foreach (var number in nums)
            {
                if (count == 0)
                {
                    current = number;
                }

                if (number == current)
                {
                    count++;
                    continue;
                }

                count--;
            }

            return current;
        }
    }
}