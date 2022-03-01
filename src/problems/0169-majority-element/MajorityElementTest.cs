using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.MajorityElement
{
    public static class MajorityElementTest
    {
        public class MajorityElementExpectations
        {
            public int[] Nums { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new MajorityElementExpectations
            {
                Nums = new []{3,2,3},
                Expectation = 3
            },
            new MajorityElementExpectations
            {
                Nums = new []{2,2,1,1,1,2,2},
                Expectation = 2
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(MajorityElementExpectations testCase)
        {
            // Arrange
            var solution = new Solution();
            var solution2 = new Solution2();

            // Act
            var result = solution.MajorityElement(testCase.Nums);
            var result2 = solution2.MajorityElement(testCase.Nums);

            // Assert
            result.Should().Be(testCase.Expectation);
            result2.Should().Be(testCase.Expectation);

            Console.WriteLine("0169 majority-element tests Success!");
        }
    }
}