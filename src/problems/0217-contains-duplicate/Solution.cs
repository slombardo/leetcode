using System.Linq;

namespace leetcode.problems.ContainsDuplicate
{
    public class Solution {
        public bool ContainsDuplicate(int[] nums)
        {
            return nums.Distinct().Count() != nums.Length;
        }
    }
}