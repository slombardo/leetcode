using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.MaximumSubarray
{
    public static class MaximumSubarrayTest
    {
        public class MaximumSubarrayExpectations
        {
            public int[] Nums { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new MaximumSubarrayExpectations
            {
                Nums = new []{-2,1,-3,4,-1,2,1,-5,4},
                Expectation = 6
            },
            new MaximumSubarrayExpectations
            {
                Nums = new []{1},
                Expectation = 1
            },
            new MaximumSubarrayExpectations
            {
                Nums = new []{-1},
                Expectation = -1
            },
            new MaximumSubarrayExpectations
            {
                Nums = new []{5,4,-1,7,8},
                Expectation = 23
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(MaximumSubarrayExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.MaxSubArray(testCase.Nums);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0053 maximum-subarray tests Success!");
        }
    }
}