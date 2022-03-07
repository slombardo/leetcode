using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.MaximumDepthOfBinaryTree
{
    public static class MaximumDepthOfBinaryTreeTest
    {
        public class MaximumDepthOfBinaryTreeExpectations
        {
            public TreeNode Root { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new MaximumDepthOfBinaryTreeExpectations
            {
                Root = new TreeNode( new int?[] {3,9,20,null,null,15,7}),
                Expectation = 3
            },
            new MaximumDepthOfBinaryTreeExpectations
            {
                Root = new TreeNode( new int?[] {1,null,2}),
                Expectation = 2
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(MaximumDepthOfBinaryTreeExpectations testCase)
        {
            // Arrange
            var solution = new Solution();

            // Act
            var result = solution.MaxDepth(testCase.Root);

            // Assert
            result.Should().Be(testCase.Expectation);

            Console.WriteLine("0104 maximum-depth-of-binary-tree tests Success!");
        }
    }
}