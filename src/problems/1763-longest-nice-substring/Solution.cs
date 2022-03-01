using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.LongestNiceSubstring
{
    public class Solution
    {
        public string LongestNiceSubstring(string s)
        {
            var longest = string.Empty;
            var toProcess = new Stack<string>();
            toProcess.Push(s);

            while (toProcess.Any())
            {
                var next = toProcess.Pop();

                var hasNonNice = false;
                for (var i = 0; i < next.Length; i++)
                {
                    var c = next[i];
                    var match = GetRespectiveMatch(c);

                    // see if there is no match
                    hasNonNice = !next.Contains(match);
                    if (!hasNonNice) continue;

                    foreach (var split in next.Split(c, StringSplitOptions.RemoveEmptyEntries).Reverse())
                    {
                        toProcess.Push(split);
                    }

                    break;
                }

                if (hasNonNice) continue;
                if (next.Length > longest.Length) longest = next;
            }

            return longest;
        }

        private static char GetRespectiveMatch(char c)
        {
            const int difference = 'a' - 'A';
            return (char)(c < 'a' ? c + difference : c - difference);
        }
    }
}