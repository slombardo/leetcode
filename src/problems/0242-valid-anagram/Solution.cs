using System.Linq;

namespace leetcode.problems.ValidAnagram
{
    public class Solution {
        public bool IsAnagram(string s, string t)
        {
            var sSorted = s.OrderBy(x => x).Where(c => c != ' ').ToArray();
            var tSorted = t.OrderBy(x => x).Where(c => c != ' ').ToArray();
            
            if (sSorted.Length != tSorted.Length) return false;

            return !sSorted.Where((t1, i) => t1 != tSorted[i]).Any();
        }
    }
}