using System;
using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.PascalsTriangleII
{
    public class PascalsTriangleTest
    {
        public class TestCase
        {
            public int NumRows { get; set; }
            public List<int> Expectation { get; set; }
        }

        private static object[] _testCaseData = {
            new TestCase { NumRows = 0, Expectation = new List<int>()  { 1 }  },
            new TestCase { NumRows = 1, Expectation = new List<int>()  { 1,1  } },
            new TestCase { NumRows = 2, Expectation = new List<int>()  { 1,2, 1 } },
            new TestCase { NumRows = 3, Expectation = new List<int>()  { 1,3, 3,1 } },
            new TestCase { NumRows = 4, Expectation = new List<int>()  { 1,4,  6, 4,1 } },
            new TestCase { NumRows = 5, Expectation = new List<int>()  { 1,5, 10,10,5,1 } },
            new TestCase { NumRows = 6, Expectation = new List<int>()  { 1,6, 15,20,15,6,1 } },
            new TestCase { NumRows = 7, Expectation = new List<int>()  { 1,7, 21,35,35,21,7,1 } },
            new TestCase { NumRows = 8, Expectation = new List<int>()  { 1,8, 28,56,70, 56,28,8,1 } },
            new TestCase { NumRows = 9, Expectation = new List<int>()  { 1,9, 36,84,126,126,84,36,9,1 } },
            new TestCase { NumRows = 10, Expectation = new List<int>() { 1,10,45,120,210,252,210,120,45,10,1 } },
            new TestCase { NumRows = 11, Expectation = new List<int>() { 1,11,55,165,330,462,462,330,165,55,11,1 } },
            new TestCase { NumRows = 12, Expectation = new List<int>() { 1,12,66,220,495,792,924,792,495,220,66,12,1 } },
            new TestCase { NumRows = 13, Expectation = new List<int>() { 1,13,78,286,715,1287,1716,1716,1287,715,286,78,13,1 } },
        };

        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(TestCase testCase)
        {
            // Arrange
            var solution = new Solution();
            
            // Act
            var result = solution.GetRow(testCase.NumRows);
            
            // Assert
            result.Should().BeEquivalentTo(testCase.Expectation);
            Console.WriteLine("0119 pascals-triangle-ii tests Success!");
        }

    }
}