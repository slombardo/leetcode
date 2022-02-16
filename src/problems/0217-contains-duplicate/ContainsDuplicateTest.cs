using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ContainsDuplicate
{
    public static class ContainsDuplicateTest
    {
        public class ContainsDuplicateExpectation
        {
            public int[] Nums { get; set; }
            public bool Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new ContainsDuplicateExpectation
            {
                Nums = new []{1,2,3,1},
                Expectation = true
            },
            new ContainsDuplicateExpectation
            {
                Nums = new []{1,2,3,4},
                Expectation = false
            },
            new ContainsDuplicateExpectation
            {
                Nums = new []{1,1,1,3,3,4,3,2,4,2},
                Expectation = true
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ContainsDuplicateExpectation testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.ContainsDuplicate(testCase.Nums);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0217 contains-duplicate tests Success!");
        }
    }
}