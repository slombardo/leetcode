namespace leetcode.problems.ExcelSheetColumnTitle
{
    public class Solution {
        public string ConvertToTitle(int columnNumber) {
            /*
                get first letter number by doing columnNumber % 26 
                get next and subsequent (loop) letter by dividing by 26 and then mod again
                repeat until dividend is 0
            */
        
            var result = "";
            var dividend = columnNumber;

            do
            {
                dividend--; // get zero-based index
                var currentLetterCode = dividend % 26 + 65;
                result = (char) currentLetterCode + result;
                dividend /= 26;
            } while (dividend >= 1);

            return result;
        }
    }
}