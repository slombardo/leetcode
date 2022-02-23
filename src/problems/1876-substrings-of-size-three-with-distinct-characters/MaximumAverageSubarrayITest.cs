using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.SubstringsOfSizeThreeWithDistinctCharacters
{
    public static class SubstringsOfSizeThreeWithDistinctCharactersTest
    {
        public class SubstringsOfSizeThreeWithDistinctCharactersExpectations
        {
            public string S { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new SubstringsOfSizeThreeWithDistinctCharactersExpectations
            {
                S = "x",
                Expectation = 0
            },
            new SubstringsOfSizeThreeWithDistinctCharactersExpectations
            {
                S = "xyzzaz",
                Expectation = 1
            },
            new SubstringsOfSizeThreeWithDistinctCharactersExpectations
            {
                S = "aababcabc",
                Expectation = 4
            },
            new SubstringsOfSizeThreeWithDistinctCharactersExpectations
            {
                S = "npdrlvffzefb",
                Expectation = 8
            },
            new SubstringsOfSizeThreeWithDistinctCharactersExpectations
            {
                S = "owuxoelszb",
                Expectation = 8
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(SubstringsOfSizeThreeWithDistinctCharactersExpectations testCase)
        {
            // Arrange
            var solution = new Solution();
            var solution2 = new Solution2();

            // Act
            var result = solution.CountGoodSubstrings(testCase.S);
            var result2 = solution2.CountGoodSubstrings(testCase.S);

            // Assert
            result.Should().Be(testCase.Expectation);
            result2.Should().Be(testCase.Expectation);

            Console.WriteLine("1876 substrings-of-size-three-with-distinct-characters tests Success!");
        }
    }
}