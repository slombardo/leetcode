using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ContainsDuplicateII
{
    public static class ContainsDuplicateIITest
    {
        public class ContainsDuplicateIIExpectation
        {
            public int[] Nums { get; set; }
            public int K { get; set; }
            public bool Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new ContainsDuplicateIIExpectation
            {
                Nums = new []{1,2,3,1},
                K = 3,
                Expectation = true
            },
            new ContainsDuplicateIIExpectation
            {
                Nums = new []{1,0,1,1},
                K = 1,
                Expectation = true
            },
            new ContainsDuplicateIIExpectation
            {
                Nums = new []{1,2,3,1,2,3},
                K = 2,
                Expectation = false
            },
            new ContainsDuplicateIIExpectation
            {
                Nums = new []{1,0,1,1},
                K = 1,
                Expectation = true
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ContainsDuplicateIIExpectation testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.ContainsNearbyDuplicate(testCase.Nums, testCase.K);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0219 contains-duplicate-ii tests Success!");
        }
    }
}