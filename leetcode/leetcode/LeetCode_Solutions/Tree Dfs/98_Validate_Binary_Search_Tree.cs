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
       /* public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }*/
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
