using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.MinimumDifferenceBetweenHighestAndLowestOfKScores
{
    public static class MinimumDifferenceBetweenHighestAndLowestOfKScoresTest
    {
        public class MinimumDifferenceBetweenHighestAndLowestOfKScoresExpectations
        {
            public int[] Nums { get; set; }
            public int K { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new MinimumDifferenceBetweenHighestAndLowestOfKScoresExpectations
            {
                Nums = new []{90},
                K = 1,
                Expectation = 0
            },
            new MinimumDifferenceBetweenHighestAndLowestOfKScoresExpectations
            {
                Nums = new []{9,4,1,7},
                K = 2,
                Expectation = 2
            },
            new MinimumDifferenceBetweenHighestAndLowestOfKScoresExpectations
            {
                Nums = new []{87063,61094,44530,21297,95857,93551,9918},
                K = 6,
                Expectation = 74560
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(MinimumDifferenceBetweenHighestAndLowestOfKScoresExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.MinimumDifference(testCase.Nums, testCase.K);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("1984 minimum-difference-between-highest-and-lowest-of-k-scores tests Success!");
        }
    }
}