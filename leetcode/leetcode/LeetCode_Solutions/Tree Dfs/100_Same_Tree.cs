using System;
using System.Collections.Generic;
using leetcode.LeetCode_Solutions.Utility;
using System.Text;

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
        public class TreeNode
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
