using System;
using System.Collections.Generic;

namespace leetcode.problems.PascalsTriangle
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            /*
             loop through numRows
             create an array with the size of the number of iterations
             first and last numbers are 1
             if the size is greater than 2, get previous row's same index and one less and add
             */
            var result = new List<IList<int>>();
            var previousRow = new List<int>();
            
            for (var rowIndex = 1; rowIndex <= numRows; rowIndex++)
            {
                var row = new List<int>(new int[rowIndex]);
                row[0] = 1;
                row[^1] = 1;
                
                var midpoint = Math.Round((decimal) rowIndex / 2, MidpointRounding.AwayFromZero);
                for (var columnIndex = 1; columnIndex < midpoint; columnIndex++)
                {
                    var currentValue = previousRow[columnIndex] + previousRow[columnIndex - 1];
                    row[columnIndex] = currentValue;
                    row[^(columnIndex + 1)] = currentValue;
                }

                previousRow = row;
                result.Add(previousRow);
            }

            return result;
        }
    }
}