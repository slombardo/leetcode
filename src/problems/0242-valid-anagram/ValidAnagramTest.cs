using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ValidAnagram
{
    public static class ValidAnagramTest
    {
        public class ValidAnagramExpectations
        {
            public string S { get; set; }
            public string T { get; set; }
            public bool Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new ValidAnagramExpectations
            {
                S = "anagram",
                T= "nagaram",
                Expectation = true
            },
            new ValidAnagramExpectations
            {
                S = "anagram",
                T= "agaram",
                Expectation = false
            },
            new ValidAnagramExpectations
            {
                S = "anagram",
                T= "aaaaaaa",
                Expectation = false
            },
            new ValidAnagramExpectations
            {
                S = "anagram",
                T= "anagram",
                Expectation = true
            },
            new ValidAnagramExpectations
            {
                S = "anagram",
                T= "",
                Expectation = false
            },
            new ValidAnagramExpectations
            {
                S = "",
                T= "anagram",
                Expectation = false
            },
            new ValidAnagramExpectations
            {
                S = "aacc",
                T= "ccac",
                Expectation = false
            },

        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ValidAnagramExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.IsAnagram(testCase.S, testCase.T);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0242 valid-anagram tests Success!");
        }
    }
}