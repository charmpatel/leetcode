/* 100 -Same Tree
   Topic - Tree, Dfs, Bfs, Binary Tree.
Given the roots of two binary trees p and q, write a function to check if they are the same or not.
Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.
Example 1:
Input: p = [1, 2, 3], q = [1, 2, 3]
Output: true
Example 2:
Input: p = [1, 2], q = [1, null, 2]
Output: false
Example 3:
Input: p = [1, 2, 1], q = [1, 1, 2]
Output: false
*/    

using System;
using System.Collections.Generic;
using leetcode.LeetCode_Solutions.Utility;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _100_Same_Tree
    {
        public _100_Same_Tree()
        {
            TreeNode p = new TreeNode(1);
            p.left = new TreeNode(2);
            p.right = new TreeNode(3);
            p.left.left = new TreeNode(2);
            p.right.left = new TreeNode(3);

            TreeNode q = new TreeNode(1);
            q.left = new TreeNode(2);
            q.right = new TreeNode(3);

            Console.WriteLine(isTreeSame(p, q));
        }
        
        public bool isTreeSame(TreeNode p, TreeNode q)
        {
            if(p == null && q == null)
            {
                return true;
            } 
            if((p == null && q != null) || (p != null && q == null) || ( p.val != q.val))
            {
                return false;
            }
            return true && isTreeSame(p.left, q.left) && isTreeSame(p.right, q.right);
        }

    }
}
