using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.ValidParentheses
{
    public class Solution {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1) return false;

            var openStack = new Stack<char>();

            for (var index = 0; index < s.Length; index++)
            {
                var c = s[index];
                if (c is '{' or '[' or '(')
                {
                    openStack.Push(c);
                    continue;
                }

                if (!openStack.Any() || openStack.Count > s.Length - index) return false;

                var open = openStack.Pop();
                if (
                    open == '(' && c == ')'
                    || open == '{' && c == '}'
                    || open == '[' && c == ']'
                ) continue;

                return false;
            }

            return !openStack.Any();
        }
    }
}