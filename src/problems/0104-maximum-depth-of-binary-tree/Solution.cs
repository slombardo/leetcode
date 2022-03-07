using System;
using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.MaximumDepthOfBinaryTree
{
    /*
     0,1,2,3,4,5,6,7,8,9,10

     0
     1, | 2
     3,4, | 5,6
     7,8, 9,10, | 11,12, 13,14,
     15,16, 17,18, 19,20, 21,22, | 23,24, 25,26, 27,28, 29,30
     */

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            Setup(val, left, right);
        }

        private void Setup(int val, TreeNode left, TreeNode right)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public TreeNode(int?[] tree)
        {
            var firstNode = GetNode(tree);
            Setup(firstNode.val, firstNode.left, firstNode.right);
        }

        private static TreeNode GetNode(IReadOnlyList<int?> tree, int currentLevel = 0)
        {
            var nodeValue = tree[currentLevel];

            if (nodeValue == null) return null;

            var leftPos = currentLevel * 2 + 1;
            var rightPos = currentLevel * 2 + 2;

            TreeNode left = null;

            // figure out left
            if (tree.Count >= leftPos )
            {
                left = GetNode(tree, leftPos);
            }

            TreeNode right = null;
            if (tree.Count >= rightPos)
            {
                right = GetNode(tree, rightPos);
            }

            return new TreeNode(nodeValue.Value, left, right);
        }
    }

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }
    }
}