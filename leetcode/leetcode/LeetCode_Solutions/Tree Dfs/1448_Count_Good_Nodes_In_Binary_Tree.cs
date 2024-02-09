/* 1448 - Count Good Nodes In Binary Tree.
   Topic - Tree, Binary Tree, Dfs, Bfs. 
Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.
Return the number of good nodes in the binary tree.
Example 1:
Input: root = [3, 1, 4, 3, null, 1, 5]
Output: 4
Explanation: Nodes in blue are good.
Root Node (3) is always a good node.
Node 4 -> (3,4) is the maximum value in the path starting from the root.
Node 5 -> (3,4,5) is the maximum value in the path
Node 3 -> (3,1,3) is the maximum value in the path.
Example 2:
Input: root = [3, 3, null, 4, 2]
Output: 3
Explanation: Node 2 -> (3, 3, 2) is not good, because "3" is higher than it.
Example 3:
Input: root = [1]
Output: 1
Explanation: Root is considered as good.
*/

using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.LeetCode_Solutions.Utility.Utility;

namespace leetcode.LeetCode_Solutions.Tree_Dfs
{
    public class _1448_Count_Good_Nodes_In_Binary_Tree
    {
        public _1448_Count_Good_Nodes_In_Binary_Tree()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(1);
            root.left.left = new TreeNode(3);
            root.right = new TreeNode(4);
            root.right.right = new TreeNode(1);
            root.right.left = new TreeNode(5);
            Console.WriteLine("Count Good Nodes= {0}", countGoodnodes(root));

        }
        int res = 0;
        public int countGoodnodes(TreeNode root)
        {
            dfs(root, root.val);
            return res;
        }
        public void dfs(TreeNode cur, int maxPath)
        {
            if(cur == null)
            {
                return;
            }
            if( cur.val >= maxPath)
            {
                maxPath = cur.val;
                res++;
            }
            dfs(cur.left, maxPath);
            dfs(cur.right, maxPath);
        }
    }
}
