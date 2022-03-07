using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.TwoSum
{
    public static class TwoSumTest
    {
        public class TwoSumExpectations
        {
            public int[] Nums { get; set; }
            public int Target { get; set; }
            public int[] Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new TwoSumExpectations
            {
                Nums = new []{2,7,11,15},
                Target = 9,
                Expectation = new []{0,1}
            },
            new TwoSumExpectations
            {
                Nums = new []{3,2,4},
                Target = 6,
                Expectation = new []{1,2}
            },
            new TwoSumExpectations
            {
                Nums = new []{3,3},
                Target = 6,
                Expectation = new []{0,1}
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(TwoSumExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.TwoSum(testCase.Nums, testCase.Target);

            // Assert
            result.Should().BeEquivalentTo(testCase.Expectation);

            Console.WriteLine("0001 two-sum tests Success!");
        }
    }
}