using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.ContainsDuplicateII
{
    public class Solution {
        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            /*
             * grab a number compare it to the last k numbers
             * - take a number put in a queue
             * - if queue is larger than k pop first one
             * - if queue contains number already, return true
             */

            var set = new HashSet<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (set.Count > k) set.Remove(nums[i - k - 1]);

                var current = nums[i];
                var currentCount = set.Count;
                set.Add(current);
                if (currentCount == set.Count) return true;
            }

            return false;
        }
    }
}