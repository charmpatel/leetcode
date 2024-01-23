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
