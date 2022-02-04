using System;

namespace leetcode.problems.MergeSortedArray
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (n == 0) return;

            for (var i = 0; i < n; i++)
            {
                var minIndex = 0;
                var maxIndex = m + i - 1;
                if (maxIndex < 0) maxIndex = 0;
                var numberToMerge = nums2[i];
                var failsafe = 100;

                do
                {
                    var middleIndex = GetMiddle(minIndex, maxIndex);

                    var middleNumber = nums1[middleIndex];
                    if (maxIndex <= minIndex)
                    {
                        var shiftFromIndex = middleIndex;
                        if (m + i > 0 && middleNumber <= numberToMerge) shiftFromIndex++;

                        ShiftRight(nums1, shiftFromIndex);

                        nums1[shiftFromIndex] = numberToMerge;
                        Console.WriteLine(string.Join(",", nums1));
                        break;
                    }

                    if (m + i <= 0) continue;
                    if (middleNumber <= numberToMerge) minIndex = middleIndex + 1;
                    else if (middleNumber > numberToMerge) maxIndex = middleIndex - 1;
                } while (--failsafe > 0);
            }
        }

        private static void ShiftRight(int[] nums1, int startIndexToShift)
        {
            for (var j = nums1.Length - 1; j > startIndexToShift; j--)
            {
                nums1[j] = nums1[j - 1];
            }
        }

        private static int GetMiddle(int min, int max)
        {
            Console.WriteLine($"{min}, {max}");
            if (min >= max) return min;
            var totalNumbersToCheck = max - min;
            var middle = totalNumbersToCheck / 2 + min;
            return middle >= max ? max : middle;
        }
    }

/*
    if n is 0 exit
    For each number in nums2, remove the final record in nums1
    Bubble sort to Find the proper index of the current number to merge
    Shift each number over
    Insert number at the proper index
*/
}