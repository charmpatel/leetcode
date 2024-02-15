/* 128 - Longest Consecutive Sequence
   Topic - Array, Hash table, Union Find.
Given an unsorted array of integers nums, return the length of the longest consecutive elements sequence.
You must write an algorithm that runs in O(n) time.
Example 1:
Input: nums = [100, 4, 200, 1, 3, 2]
Output: 4
Explanation: The longest consecutive elements sequence is [1, 2, 3, 4]. Therefore its length is 4.
Example 2:
Input: nums = [0, 3, 7, 2, 5, 8, 4, 6, 0, 1]
Output: 9
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _128_Longest_Consecutive_Sequence
    {
        public _128_Longest_Consecutive_Sequence()
        {
            int[] nums = new int[] { 100, 4, 200, 1, 3, 2 };
            int[] num1 = new int[] { 0, 2, 5, 8, 1, 4, 7, 3, 6, 10 };
            Console.WriteLine("Longest Consecutive= {0}", longestConsecutive(nums));
            Console.WriteLine("Longest Consecutive= {0}", longestConsecutive(num1));
        }
        public int longestConsecutive(int[] nums)
        {
            if(nums.Length == 0)
            {
                return 0;
            }
            HashSet<int> hs = new HashSet<int>(nums);
            int ans = 1;
            foreach(int num in nums)
            {
                if(hs.Contains(num - 1))
                {
                    continue;
                }
                int count = 1;
                while(hs.Contains(num + count))
                {
                    count++;
                }
                ans = Math.Max(count, ans);
            }
            return ans;
        }
    }
}
