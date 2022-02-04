using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.MergeSortedArray
{
    public static class MergeSortedArrayTest
    {
        public class TestCase
        {
            public int[] Nums1 { get; set; }
            public int M { get; set; }
            public int[] Nums2 { get; set; }
            public int N { get; set; }
            public int[] Expectation { get; set; }
        }

        private static object[] _testCaseData = {
            
            new TestCase { Nums1 = new []{1,2,3,0,0,0}, M = 3, Nums2 = new []{2,5,6}, N = 3, Expectation = new []{1,2,2,3,5,6}},
            new TestCase { Nums1 = new []{1,2,3,0,0,0,0,0}, M = 3, Nums2 = new []{1,2,3,4,5}, N = 5, Expectation = new []{1,1,2,2,3,3,4,5}},
            new TestCase { Nums1 = new []{0,0,0,0,0}, M = 0, Nums2 = new []{1,2,3,4,5}, N = 5, Expectation = new []{1,2,3,4,5}},
            new TestCase { Nums1 = new []{1}, M = 1, Nums2 = new int[0], N = 0, Expectation = new []{1}},
            new TestCase { Nums1 = new []{1,2,3,5,79,85,603,0,0,0,0,0,0,0,0}, M = 7, Nums2 = new []{1,2,52,2,199,3,4,5}, N = 8, Expectation = new []{1,1,2,2,2,3,3,4,5,5,52,79,85,199,603}},
        }; 

        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(TestCase testCase)
        {
            // Arrange
            var solution = new Solution();
            
            // Act
            solution.Merge(testCase.Nums1, testCase.M, testCase.Nums2, testCase.N);
            
            // Assert
            testCase.Nums1.Should().BeEquivalentTo(testCase.Expectation);
            
            Console.WriteLine("0088 merge-sorted-array tests Success!");
        }
    }
}