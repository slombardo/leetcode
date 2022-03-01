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
                if(next.Length <= longest.Length) continue;

                var hasNonNice = false;

                // look for the first non-nice char
                for (var i = 0; i < next.Length; i++)
                {
                    var c = next[i];
                    var match = GetRespectiveMatch(c);

                    hasNonNice = !next.Contains(match);
                    if (!hasNonNice) continue;

                    // Since there is a non-nice, split the string there.
                    // We are iterating backwards since stack is "filo" and we want the left most string to be processed first.
                    var splits = next.Split(c, StringSplitOptions.RemoveEmptyEntries);
                    for (var j = splits.Length - 1; j >= 0; j--)
                    {
                        var split = splits[j];
                        // if the split is already smaller than or equal to the longest, toss it.
                        if(split.Length <= longest.Length) continue;

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