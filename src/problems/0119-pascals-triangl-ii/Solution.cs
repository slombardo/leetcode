using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.PascalsTriangleII
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<int> previousRow = null;

            for (var i = 0; i <= rowIndex; i++)
            {
                var row = new List<int>(new int[i + 1]);
                row[0] = 1;
                row[^1] = 1;

                var midpoint = Math.Round((decimal) (i + 1) / 2, MidpointRounding.AwayFromZero);
                for (var columnIndex = 1; columnIndex < midpoint; columnIndex++)
                {
                    var currentValue = previousRow[columnIndex] + previousRow[columnIndex - 1];
                    row[columnIndex] = currentValue;
                    row[^(columnIndex + 1)] = currentValue;
                }

                previousRow = row;
            }

            return previousRow;
        }
    }
}