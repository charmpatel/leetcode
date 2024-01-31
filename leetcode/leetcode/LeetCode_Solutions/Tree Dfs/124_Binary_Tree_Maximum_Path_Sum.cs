﻿using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _124_Binary_Tree_Maximum_Path_Sum
    {
        public _124_Binary_Tree_Maximum_Path_Sum()
        {
            TreeNode root = new TreeNode(-10);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.right = new TreeNode(7);
            root.right.left = new TreeNode(15);
            root.right.right.right = new TreeNode(18);

            Console.WriteLine(MaxPathSum(root));
        }
       /* A path in a binary tree is a sequence of nodes where each pair of adjacent nodes in the sequence has an edge connecting them.A node can only appear in the sequence at most once.Note that the path does not need to pass through the root.
        The path sum of a path is the sum of the node's values in the path.Given the root of a binary tree, return the maximum path sum of any non-empty path.
        Example 1:
        Input: root = [1, 2, 3]
        Output: 6
        Explanation: The optimal path is 2 -> 1 -> 3 with a path sum of 2 + 1 + 3 = 6.
        Example 2:
        Input: root = [-10, 9, 20, null, null, 15, 7]
        Output: 42
        Explanation: The optimal path is 15 -> 20 -> 7 with a path sum of 15 + 20 + 7 = 42.*/

        int result = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            DFS(root);
            return result;
        }
        private int DFS(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int leftSum = Math.Max(0, DFS(node.left));
            int rightSum = Math.Max(0, DFS(node.right));
            result = Math.Max(result, node.val + leftSum + rightSum);
            return (node.val + Math.Max(leftSum, rightSum));
        }
    }
}