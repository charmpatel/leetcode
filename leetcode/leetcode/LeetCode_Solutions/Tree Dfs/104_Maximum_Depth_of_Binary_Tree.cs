/* 104 - Maximum Depth Of Binary Tree.
   Topic - Tree, Dfs, Bfs, Binary Tree.
iven the root of a binary tree, return its maximum depth.
A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
Example 1:
Input: root = [3, 9, 20, null, null, 15, 7]
Output: 3
Example 2:
Input: root = [1, null, 2]
Output: 2
*/

using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _104_Maximum_Depth_of_Binary_Tree
    {
        public _104_Maximum_Depth_of_Binary_Tree()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.right = new TreeNode(7);
            root.right.left = new TreeNode(15);
            root.right.right.right = new TreeNode(18);

            Console.WriteLine(DFS(root));

        }

        public int MaxDepth(TreeNode root)
        {
            return DFS(root);
        }
        public int DFS(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            var left = 1 + MaxDepth(root.left);
            var right = 1 + MaxDepth(root.right);
            return Math.Max(left, right);
        }
    }
}
