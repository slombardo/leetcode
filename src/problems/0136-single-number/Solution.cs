using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.SingleNumber
{
    public enum Direction
    {
        Left,
        Right
    }
    public class Solution {
        /// <remarks>
        /// Logic:
        ///     - remove each number as you iterate
        ///     - see if firsts array contains number 
        ///     - if so, remove from firsts array
        ///     - if not, add removed number to firsts array
        ///     - once finished, firsts should only have 1 item
        ///     -
        ///
        ///   Pros
        ///     - reduced enumerations (only 1)
        ///     - 
        ///
        ///   Cons
        ///     - must iterate the entire collection  
        ///     -  
        /// </remarks>
        public int SingleNumber(int[] nums)
        {
            if (nums.Length == 1) return nums[0];
            
            var firsts = new List<int>();
            var numsStack = new Stack<int>(nums);
            
            while (numsStack.Count > 0)
            {
                var current = numsStack.Pop();
                var foundIndex = firsts.IndexOf(current);
                if (foundIndex != -1) firsts.RemoveAt(foundIndex);
                else firsts.Add(current);
            }

            return firsts[0];
        }
    }    
    public class Solution2 {
        /// <remarks>
        /// Logic:
        ///     - Use link to get only unique... 
        ///
        ///   Pros
        ///     - 1 line of code
        ///
        ///   Cons
        ///     -  performance, maybe?
        /// </remarks>
        public int SingleNumber(int[] nums)
        {
            return nums.GroupBy(i => i)
                .Where(g => g.Count() == 1)
                .Select(g => g.First())
                .FirstOrDefault();
        }
    }

    /// <summary>
    /// Found here: https://leetcode.com/problems/single-number/discuss/1137987/C-math-one-liner
    /// Really liked this one.  Reminded me that sometimes, objects are just... numbers.
    /// </summary>
    public class Solution3
    {
        /// <remarks>
        /// Quick maths
        /// </remarks>
        public int SingleNumber(int[] nums)
        {
            return nums.Distinct().Sum() * 2 - nums.Sum();
        }
    }
}