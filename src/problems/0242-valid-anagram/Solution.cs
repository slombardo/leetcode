using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace leetcode.problems.ValidAnagram
{
    public class Solution {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var sSorted = s.OrderBy(x => x);
            var tSorted = t.OrderBy(x => x).ToArray();
            
            return !sSorted.Where((t1, i) => t1 != tSorted[i]).Any();
        }
    }
}