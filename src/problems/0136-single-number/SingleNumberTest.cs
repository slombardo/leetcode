using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.SingleNumber
{
    public static class SingleNumberTest
    {
        public class SingleNumberExpectations
        {
            public int[] Nums { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            //just one
            new SingleNumberExpectations
            {
                Nums = new[] {1},
                Expectation = 1
            },
            // single is lowest, 3
            new SingleNumberExpectations
            {
                Nums = new[] {2, 2, 1},
                Expectation = 1
            },
            // single is highest, 3
            new SingleNumberExpectations
            {
                Nums = new[] {2, 1, 1},
                Expectation = 2
            },
            // single is lowest, 5
            new SingleNumberExpectations
            {
                Nums = new[] {4, 4, 2, 1, 2},
                Expectation = 1
            },
            // single is highest, 5
            new SingleNumberExpectations
            {
                Nums = new[] {4, 1, 2, 1, 2},
                Expectation = 4
            },
            // single is in between, 5
            new SingleNumberExpectations
            {
                Nums = new[] {4, 1, 2, 1, 2},
                Expectation = 4
            },
            // single is lowest, 7
            new SingleNumberExpectations
            {
                Nums = new[] {4, 4, 2, 1, 2, 33, 33},
                Expectation = 1
            },
            // single is highest, 7
            new SingleNumberExpectations
            {
                Nums = new[] {4, 1, 2, 1, 2, 4, 33},
                Expectation = 33
            },
            // single is in between, 7
            new SingleNumberExpectations
            {
                Nums = new[] {4, 1, 2, 1, 2, 33, 33},
                Expectation = 4
            },
            // single is lowest, 9
            new SingleNumberExpectations
            {
                Nums = new[] {4, 4, 2, 1, 2, 33, 33, 44, 44},
                Expectation = 1
            },
            // single is highest, 7
            new SingleNumberExpectations
            {
                Nums = new[] {4, 1, 2, 1, 2, 4, 11, 11, 33},
                Expectation = 33
            },
            // single is in between, 7
            new SingleNumberExpectations
            {
                Nums = new[] {4, 1, 2, 1, 2, 33, 33, 44, 44},

                Expectation = 4
            },
        };

        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(SingleNumberExpectations testCase)
        {
            // Arrange
            var solution1 = new Solution();
            var solution2 = new Solution2();
            var solution3 = new Solution3();

            // Act
            var result1 = solution1.SingleNumber(testCase.Nums);
            var result2 = solution2.SingleNumber(testCase.Nums);
            var result3 = solution3.SingleNumber(testCase.Nums);

            // Assert
            result1.Should().Be(testCase.Expectation);
            result2.Should().Be(testCase.Expectation);
            result3.Should().Be(testCase.Expectation);

            Console.WriteLine("0136 single-number tests Success!");
        }
    }
}