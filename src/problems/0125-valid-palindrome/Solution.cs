using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace leetcode.problems.ValidPalindrome
{
    public class Solution {
        private const string Pattern = "[^a-z0-9]";
        private static readonly Regex Regex = new(Pattern, RegexOptions.IgnoreCase);
        
        public bool IsPalindrome(string s)
        {
            s = Regex.Replace(s, string.Empty);
            return string.Equals(s, new string(s.Reverse().ToArray()), StringComparison.CurrentCultureIgnoreCase);
        }
    }
    public class Solution2 {
        public bool IsPalindrome(string s)
        {
            var leftIndex = 0;
            var rightIndex = 0;
            
            while (!MidPointCrossed(s, leftIndex, rightIndex))
            {
                char left;
                bool validCharFound;
                do
                {
                    left = s[leftIndex++];
                    validCharFound = IsInRange(left);
                } while (!validCharFound && leftIndex < s.Length);

                if(!validCharFound) break;
                
                char right;
                do
                {
                    right = s[^++rightIndex];
                } while (!IsInRange(right) && rightIndex < s.Length);

                if (char.ToLowerInvariant(left) != char.ToLowerInvariant(right)) return false;
            }

            return true;
        }

        private static bool MidPointCrossed(string s, int leftIndex, int rightIndex)
        {
            return leftIndex + rightIndex >= s.Length;
        }

        private static bool IsInRange(char c)
        {
            return c is >= 'A' and <= 'Z'
                or >= 'a' and <= 'z'
                or >= '0' and <= '9';
        }
    }
}