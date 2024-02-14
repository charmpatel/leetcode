/* 113 - Path Sum 2.
   Topic - Tree, Dfs, Bfs, Binary Tree.
Given the root of a binary tree and an integer targetSum, return all root-to-leaf paths where the sum of the node values in the path equals targetSum. Each path should be returned as a list of the node values, not node references.
A root-to-leaf path is a path starting from the root and ending at any leaf node. A leaf is a node with no children.
Example 1:
Input: root = [5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1], targetSum = 22
Output:[[5,4,11,2],[5,8,4,5]]
Explanation: There are two paths whose sum equals targetSum:
5 + 4 + 11 + 2 = 22
5 + 8 + 4 + 5 = 22
Example 2:
Input: root = [1, 2, 3], targetSum = 5
Output:[]
Example 3:
Input: root = [1, 2], targetSum = 0
Output:[]
*/

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
