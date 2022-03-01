using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.LongestNiceSubstring
{
    public static class LongestNiceSubstringTest
    {
        public class LongestNiceSubstringExpectations
        {
            public string S { get; set; }
            public string Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new LongestNiceSubstringExpectations
            {
                S = "YazaAay",
                Expectation = "aAa"
            },
            new LongestNiceSubstringExpectations
            {
                S = "Bb",
                Expectation = "Bb"
            },
            new LongestNiceSubstringExpectations
            {
                S = "c",
                Expectation = ""
            },
            new LongestNiceSubstringExpectations
            {
                S = "VaiOlVBrVyoGqygbrELjHNyRAVmHDhtSsvLMCIeFStnoyTygcrMduvyYfJQ",
                Expectation = "Ss"
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(LongestNiceSubstringExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.LongestNiceSubstring(testCase.S);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("1763 longest-nice-substring tests Success!");
        }
    }
}