using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ValidParentheses
{
    public static class ValidParenthesesTest
    {
        public class ValidParenthesesExpectations
        {
            public string S { get; set; }
            public bool Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new ValidParenthesesExpectations
            {
                S = "()",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "[]",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "{}",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "{",
                Expectation = false
            },
            new ValidParenthesesExpectations
            {
                S = "[",
                Expectation = false
            },
            new ValidParenthesesExpectations
            {
                S = "(",
                Expectation = false
            },
            new ValidParenthesesExpectations
            {
                S = "()()",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "()(",
                Expectation = false
            },
            new ValidParenthesesExpectations
            {
                S = "[][]",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "[][",
                Expectation = false
            },
            new ValidParenthesesExpectations
            {
                S = "[({[]})]",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "[({[]})]{}",
                Expectation = true
            },
            new ValidParenthesesExpectations
            {
                S = "[({[]})][",
                Expectation = false
            },
            new ValidParenthesesExpectations
            {
                S = "[({[(]})]",
                Expectation = false
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ValidParenthesesExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsValid(testCase.S);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0020 valid-parentheses tests Success!");
        }
    }
}