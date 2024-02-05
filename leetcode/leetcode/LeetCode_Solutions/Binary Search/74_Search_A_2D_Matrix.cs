/* 74 - Search A 2D Matrix
  topic - Array, Binary Search, Matrix.
You are given an m x n integer matrix matrix with the following two properties:
Each row is sorted in non-decreasing order.
The first integer of each row is greater than the last integer of the previous row.
Given an integer target, return true if target is in matrix or false otherwise.
You must write a solution in O(log(m * n)) time complexity.
Example 1:
Input: matrix = [[1, 3, 5, 7], [10,11,16,20], [23,30,34,60]], target = 3
Output: true
Example 2:
Input: matrix = [[1, 3, 5, 7],[10,11,16,20],[23,30,34,60]], target = 13
Output: false
*/
 

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Binary_Search
{
    public class _74_Search_A_2D_Matrix
    {
        public _74_Search_A_2D_Matrix()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20},
                new int[] { 23, 30, 34, 60 }
            };
            int target = 3;
            Console.WriteLine("Search 2D Matrix {0} ", searchMatrix(arr, target));
            int[][] arr1 = new int[][]
            {
                new int[] { 1, 3, 5, 7 },
                new int[] { 10, 11, 16, 20},
                new int[] { 23, 30, 34, 60 }
            };
            int test = 13;
            Console.WriteLine("Search 2D Matrix {0} ", searchMatrix(arr1, test));
        }
        public bool searchMatrix(int[][] matrix, int target)
        {
            int m = matrix.Length;
            int n = matrix[0].Length;
            int i = 0;
            int j = n - 1;
            while( i >= 0 && i < n && j >= 0 && j < n)
            {
                if(matrix[i][j] == target)
                {
                    return true;
                }
                else if(matrix[i][j] > target)
                {
                    j--;
                }
                else if (matrix[i][j] < target)
                {
                    i++;
                }
            }
            return false;
        }
        
    }
}
