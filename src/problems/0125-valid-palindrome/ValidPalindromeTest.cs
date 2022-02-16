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
                S = "...A man, a plan, a canal: Panama[=][",
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
                S = "race e-car",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "anagramargana",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "a1nagra2m2argan1A",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = ".",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = ".,",
                Expectation = true
            },
            new ValidPalindromeExpectations
            {
                S = "0P",
                Expectation = false
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ValidPalindromeExpectations testCase)
        {
            // Arrange
            var solution = new Solution();
            var solution2 = new Solution2();

            // Act
            var result = solution.IsPalindrome(testCase.S);
            var result2 = solution2.IsPalindrome(testCase.S);
            // Assert
            result.Should().Be(testCase.Expectation);
            result2.Should().Be(testCase.Expectation);

            Console.WriteLine("0125 valid-palindrome tests Success!");
        }
    }
}