/* 98 - Validate Binary Search Tree
   Topic - Tree, Dfs, Bfs, Binary Tree.
Given the root of a binary tree, determine if it is a valid binary search tree (BST).
A valid BST is defined as follows:
The left subtree of a node contains only nodes with keys less than the node's key.
The right subtree of a node contains only nodes with keys greater than the node's key.
Both the left and right subtrees must also be binary search trees.
Example 1:
Input: root = [2, 1, 3]
Output: true
Example 2:
Input: root = [5, 1, 4, null, null, 3, 6]
Output: false
Explanation: The root node 's value is 5 but its right child's value is 4.
*/

using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _98_Validate_Binary_Search_Tree
    {
        public _98_Validate_Binary_Search_Tree()
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.right = new TreeNode(5);
            //root.right.left = newNode(7);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);

            Console.WriteLine(isValidBinaryTree(root));
        }
       
        public bool isValidBinaryTree(TreeNode root)
        {
            return isValidBinaryTree(root, null, null);
        }
        public bool isValidBinaryTree(TreeNode root, int? min, int? max)
        {
            if (root == null)
            {
                return true;
            }
            if (min.HasValue && root.val <= min)
            {
                return false;
            }
            if (max.HasValue && root.val >= max)
            {
                return false;
            }
            return isValidBinaryTree(root.left, min, root.val) && isValidBinaryTree(root.right, root.val, max);

        }
    }
}
