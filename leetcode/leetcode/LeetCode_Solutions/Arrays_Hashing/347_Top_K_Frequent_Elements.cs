/* 347 - Top K Frequent Elements
   topic - Array, Hash Table, Sorting, Priority Queue, Divide and Conquer, Bucket Sort, QuickSelect, Counting.
Given an integer array nums and an integer k, return the k most frequent elements. You may return the answer in any order.
Example 1:
Input: nums = [1, 1, 1, 2, 2, 3], k = 2
Output:[1,2]
Example 2:
Input: nums = [1], k = 1
Output:[1]
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _347_Top_K_Frequent_Elements
    {
        public _347_Top_K_Frequent_Elements()
        {
            int[] nums = new int[] { 1, 1, 1, 2, 2, 3,3,3,3,3 };
            int k = 2;
            var ans =topKElements(nums, k);
            foreach(var i in ans)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine(" ");
        }

        public int[] topKElements(int[] nums, int k)
        {
            int[] res = new int[k];
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach(int i in nums)
            {
                if (!dict.ContainsKey(i))
                {
                    dict.Add(i, 1);
                }
                else
                {
                    dict[i]++;
                }
            }
            var ordered = dict.OrderByDescending(x => x.Value).Take(k).ToList();

            for(int i = 0; i < ordered.Count; i++)
            {
                res[i] = ordered[i].Key;
            }
            return res;
        }

    }

}
