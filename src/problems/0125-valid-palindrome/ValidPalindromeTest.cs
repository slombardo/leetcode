using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ValidPalindrome
{
    public static class ValidPalindromeTest
    {
        public class ValidPalindromeExpectations
        {
            public string S { get; set; }
            public bool Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new ValidPalindromeExpectations
            {
                S = "A man, a plan, a canal: Panama",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "race a car",
                Expectation = false
            },
            new ValidPalindromeExpectations
            {
                S = "race  car",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "anagramargana",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "a1nagra2m2argan1a",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "",
                Expectation = true
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ValidPalindromeExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsPalindrome(testCase.S);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0125 valid-palindrome tests Success!");
        }
    }
}