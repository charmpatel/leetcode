using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _113_Path_Sum_2
    {
        public _113_Path_Sum_2()
        {
            TreeNode root = new TreeNode(5);
            root.left = new TreeNode(4);
            root.left.left = new TreeNode(11);
            root.left.left.right = new TreeNode(7);
            root.left.left.left = new TreeNode(2);
            root.right = new TreeNode(8);
            root.right.left = new TreeNode(13);
            root.right.right = new TreeNode(4);
            root.right.right.left = new TreeNode(5);
            root.right.right.right = new TreeNode(1);
            int targetSum = 22;
            var result = pathSum(root, targetSum);
            //Console.WriteLine(pathSum(root, targetSum));
            foreach(var i in result)
            {

                Console.Write("[");
                foreach (var j in i)
                {
                    Console.Write("{0},",j);
                }
                Console.Write("],");
            }
        }

        
        public class root
        {
            int key;
            root left, right;
            public root(int item)
            {
                key = item;
                left = right = null;
            }
        }
       
        public IList<IList<int>> pathSum(TreeNode root, int targetSum)
        {
            var result = new List<IList<int>>();
            DFS(root, 0, new List<int>());
            return result;
            void DFS(TreeNode root, int Sum, List<int> currpath)
            {
                if(root == null)
                {
                    return;
                }
                Sum += root.val;
                currpath.Add(root.val);
                if(root.left == null && root.right == null && Sum == targetSum)
                {
                    result.Add(currpath);
                    return;
                }
                else
                {
                    DFS(root.left, Sum, new List<int>(currpath));
                    DFS(root.right, Sum, new List<int>(currpath));
                }
            }
        }
    }
}
