using System;
using System.Linq;

namespace leetcode.problems.SubstringsOfSizeThreeWithDistinctCharacters
{
    public class Solution
    {
        public int CountGoodSubstrings(string s)
        {
            if (s.Length < 3) return 0;
            var total = 0;

            for (var i = 3; i <= s.Length; i++)
            {
                var start = i - 3;
                var count = s[start..i].Distinct().Count();
                if (count == 3) total++;
            }

            return total;
        }
    }

    public class Solution2
    {
        /*
         * first = 2
         * second = 7
         * diff = 5
         * total = 9
         * third  = 7
         *
         * thirdDiff = total - third = 2
         * thirdDiff - third = 5
         *
         * diff - third == third - total
         * -------------------
         * first = 2
         * second = 7
         * diff = 5
         * total = 9
         * third = 2
         *
         * thirdDiff = total - third = 7
         * thirdDiff - third = 5
         */

        public int CountGoodSubstrings(string s)
        {
            if (s.Length < 3) return 0;

            var prev = s[1];
            var previousDiff = s[0] - prev;
            var count = 0;

            for (var i = 2; i < s.Length; i++)
            {
                var next = s[i];
                var currentDiff = prev - next;

                if (previousDiff != 0 && currentDiff != 0 && previousDiff + currentDiff != 0) count++;

                previousDiff = currentDiff;
                prev = next;
            }

            return count;
        }
    }
}