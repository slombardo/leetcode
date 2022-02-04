using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.SpiralMatrix
{
    public static class SpiralMatrixTest
    {
        public class MatrixExpectations
        {
            public int[][] Matrix { get; set; }
            public int[] Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new MatrixExpectations
            {
                Matrix = new[]
                {
                    new[] {1, 2, 3},
                    new[] {4, 5, 6},
                    new[] {7, 8, 9}
                },
                Expectation = new[] {1, 2, 3, 6, 9, 8, 7, 4, 5}
            },
            new MatrixExpectations
            {
                Matrix = new[]
                {
                    new[] {1, 2, 3, 4},
                    new[] {5, 6, 7, 8},
                    new[] {9, 10, 11, 12}
                },
                Expectation = new[] {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7}
            },
            new MatrixExpectations
            {
                Matrix = new[]
                {
                    new[] {1, 2, 3, 4},
                    new[] {4, 5, 6, 7},
                    new[] {7, 8, 9, 10}
                },
                Expectation = new[] {1, 2, 3, 4, 7, 10, 9, 8, 7, 4, 5, 6}
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(MatrixExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.SpiralOrder(testCase.Matrix);

            // Assert
            result.Should().BeEquivalentTo(testCase.Expectation);

            Console.WriteLine("0054 spiral-matrix tests Success!");
        }
    }
}