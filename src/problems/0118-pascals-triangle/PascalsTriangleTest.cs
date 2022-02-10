using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.PascalsTriangle
{
    public class PascalsTriangleTest
    {
        public class TestCase
        {
            public int NumRows { get; set; }
            public List<List<int>> Expectation { get; set; }
        }

        private static object[] _testCaseData = {
            new TestCase { NumRows = 1, Expectation = new List<List<int>>() { new() {1} } },
            new TestCase { NumRows = 2, Expectation = new List<List<int>>() { new() {1}, new() {1,1} } },
            new TestCase { NumRows = 3, Expectation = new List<List<int>>() { new() {1}, new() {1,1}, new() {1,2,1} } },
            new TestCase { NumRows = 4, Expectation = new List<List<int>>() { new() {1}, new() {1,1}, new() {1,2,1}, new() {1,3,3,1} } },
            new TestCase { NumRows = 5, Expectation = new List<List<int>>() { new() {1}, new() {1,1}, new() {1,2,1}, new() {1,3,3,1}, new() {1,4,6,4,1} } },
            new TestCase { NumRows = 6, Expectation = new List<List<int>>() { new() {1}, new() {1,1}, new() {1,2,1}, new() {1,3,3,1}, new() {1,4,6,4,1}, new() {1,5,10,10,5,1} } },
            new TestCase { NumRows = 7, Expectation = new List<List<int>>() { new() {1}, new() {1,1}, new() {1,2,1}, new() {1,3,3,1}, new() {1,4,6,4,1}, new() {1,5,10,10,5,1}, new() {1,6,15,20,15,6,1} } },
        }; 

        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(TestCase testCase)
        {
            // Arrange
            var solution = new Solution();
            
            // Act
            var result = solution.Generate(testCase.NumRows);
            
            // Assert
            result.Should().BeEquivalentTo(testCase.Expectation);
            Console.WriteLine("0118 pascals-triangle tests Success!");
        }

    }
}