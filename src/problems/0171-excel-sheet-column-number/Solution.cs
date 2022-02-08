using System;

namespace leetcode.problems.ExcelSheetColumnNumber
{
    public class Solution {
        public int TitleToNumber(string columnTitle) {
            /*
                Loop for each character in the title
                Get the first letter and determine ascii code
                Subtract 64 to get letter index
                Multiply letter index by 26 ^ digits from the right
                Add result to the return value                
            */
            var result = 0;
            for (var i = 0; i < columnTitle.Length; i++)
            {
                var letterIndex = columnTitle[i] - 64;
                var indexFromRight = columnTitle.Length - i - 1;
                result += letterIndex * (int) Math.Pow(26, indexFromRight);
            }
            return result;
        }
    }
}