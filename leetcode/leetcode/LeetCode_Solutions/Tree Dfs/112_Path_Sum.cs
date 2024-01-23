using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _112_Path_Sum
    {
        public _112_Path_Sum()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(11);
            root.left.left.right = new TreeNode(7);
            root.left.left.left = new TreeNode(2);
            root.right = new TreeNode(8);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.right = new TreeNode(1);
            int targetSum = 22;

            Console.WriteLine(isPathSum(root, targetSum));
        }

        public bool isPathSum(TreeNode root, int targetSum)
        {
            if(root == null)
            {
                return false;
            }
            if(root.left == null && root.right == null)
            {
                return targetSum == root.val;
            }
            bool right = isPathSum(root.right, targetSum - root.val);
            bool left = isPathSum(root.left, targetSum - root.val);
            return left || right;
        }

    }
}
