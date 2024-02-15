/* 769 - Max Chunks To Make Sorted.
   Topic - Array, Sorting, Stack, Greedy, Monotonic Stack.
You are given an integer array arr of length n that represents a permutation of the integers in the range [0, n - 1].
We split arr into some number of chunks (i.e., partitions), and individually sort each chunk. After concatenating them, the result should equal the sorted array.
Return the largest number of chunks we can make to sort the array.
Example 1:
Input: arr = [4, 3, 2, 1, 0]
Output: 1
Explanation:
Splitting into two or more chunks will not return the required result.
For example, splitting into [4, 3], [2, 1, 0] will result in [3, 4, 0, 1, 2], which isn't sorted.
Example 2:
Input: arr = [1, 0, 2, 3, 4]
Output: 4
Explanation:
We can split into two chunks, such as [1, 0], [2, 3, 4].
However, splitting into[1, 0], [2], [3], [4] is the highest number of chunks possible.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _769_Max_Chunks_To_Make_Sorted
    {
        public _769_Max_Chunks_To_Make_Sorted()
        {
            int[] arr = new int[] { 4, 3, 2, 1, 0 };
            int[] arr1 = new int[] { 1, 0, 2, 3, 4 };
            Console.WriteLine("Max Chunks To Make Sorted= {0}", maxChunks(arr));
            Console.WriteLine("Max Chunks To Make Sorted= {0}", maxChunks(arr1));
        }
        public int maxChunks(int[] arr)
        {
            int max = 0;
            int chunks = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                max = Math.Max(max, arr[i]);
                if(max == i)
                {
                    chunks++;
                }
            }
            return chunks;
        }
    }
}
