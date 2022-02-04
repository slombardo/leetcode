using System;
using FluentAssertions;

namespace leetcode.problems
{
    public static class SpiralMatrixTest
    {
        private class MatrixExpectations
        {
            public int[][] Matrix { get; set; }
            public int[] Expectation { get; set; }
        }

        public static void RunTests()
        {
            // Arrange
            var testCases = new MatrixExpectations[]
            {
                new()
                {
                    Matrix = new[]
                    {
                        new[] {1, 2, 3},
                        new[] {4, 5, 6},
                        new[] {7, 8, 9}
                    },
                    Expectation = new[] {1, 2, 3, 6, 9, 8, 7, 4, 5}
                },
                new()
                {
                    Matrix = new[]
                    {
                        new[] {1, 2, 3, 4},
                        new[] {5, 6, 7, 8},
                        new[] {9, 10, 11, 12}
                    },
                    Expectation = new[] {1, 2, 3, 4, 8, 12, 11, 10, 9, 5, 6, 7}
                },
                new()
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
            var solution = new Solution();

            // Act
            var result1 = solution.SpiralOrder(testCases[0].Matrix);
            var result2 = solution.SpiralOrder(testCases[1].Matrix);
            var result3 = solution.SpiralOrder(testCases[2].Matrix);

            // Assert
            result1.Should().BeEquivalentTo(testCases[0].Expectation);
            result2.Should().BeEquivalentTo(testCases[1].Expectation);
            result3.Should().BeEquivalentTo(testCases[2].Expectation);

            Console.WriteLine("Success!");
        }
    }
}