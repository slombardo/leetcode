using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using NUnit.Framework;

namespace leetcode.problems.ValidParentheses
{
    public class Solution {
        public bool IsValid(string s)
        {
            if (s.Length % 2 == 1) return false;
            var index = 0;
            return ValidateOpenClose(s, ref index);
        }

        private static bool ValidateOpenClose(string s, ref int index)
        {
            var open = s[index++];
            if (open is not ('{' or '[' or '(')) return false;
            if (index >= s.Length) return false;

            while (index < s.Length)
            {
                var next = s[index];
                if (
                    open == '(' && next == ')'
                    || open == '{' && next == '}'
                    || open == '[' && next == ']'
                )
                {
                    index++;
                    return true;
                }

                if (next is '{' or '[' or '(')
                {
                    if (!ValidateOpenClose(s, ref index)) return false;
                }
            }

            return false;
        }
    }
}