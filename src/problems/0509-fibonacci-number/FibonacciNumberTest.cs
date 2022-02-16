using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.FibonacciNumber
{
    public static class FibonacciNumberTest
    {
        public class FibonacciNumberExpectations
        {
            public int N { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new FibonacciNumberExpectations
            {
                N = 0,
                Expectation = 0
            },
            new FibonacciNumberExpectations
            {
                N = 1,
                Expectation = 1
            },
            new FibonacciNumberExpectations
            {
                N = 2,
                Expectation = 1
            },
            new FibonacciNumberExpectations
            {
                N = 3,
                Expectation = 2
            },
            new FibonacciNumberExpectations
            {
                N = 4,
                Expectation = 3
            },
            new FibonacciNumberExpectations
            {
                N = 5,
                Expectation = 5
            },
            new FibonacciNumberExpectations
            {
                N = 6,
                Expectation = 8
            },
            new FibonacciNumberExpectations
            {
                N = 7,
                Expectation = 13
            },
            new FibonacciNumberExpectations
            {
                N = 8,
                Expectation = 21
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(FibonacciNumberExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.Fib(testCase.N);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0509 fibonacci-number tests Success!");
        }
    }
}