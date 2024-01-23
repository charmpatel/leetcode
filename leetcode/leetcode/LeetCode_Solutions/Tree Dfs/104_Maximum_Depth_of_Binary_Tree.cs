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
