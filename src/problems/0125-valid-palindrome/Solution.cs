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
}