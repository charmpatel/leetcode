/* 215 - Kth Largest Element In A Array
   Topic - Array, Divide and Conqure, Sorting, Heap (Priority Queue), Quickselect.
Given an integer array nums and an integer k, return the kth largest element in the array.
Note that it is the kth largest element in the sorted order, not the kth distinct element.
Can you solve it without sorting?
Example 1:
Input: nums = [3, 2, 1, 5, 6, 4], k = 2
Output: 5
Example 2:
Input: nums = [3, 2, 3, 1, 2, 4, 5, 5, 6], k = 4
Output: 4
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Heap_Priority_Queue_
{
    public class _215_KTh_Largest_Element_In_An_Array
    {
        public _215_KTh_Largest_Element_In_An_Array()
        {
            int k = 2;
            int[] nums = new int[] { 3, 2, 1, 5, 6, 4 };
            Console.WriteLine("Kth Largest Element In A Array {0} ", findLagestEleArray(nums, k)); 
        }
        public int findLagestEleArray(int[] nums, int k)
        {
            Heap_Priority_Queue_<int, int> pq = Heap_Priority_Queue_<int, int>();
            foreach(int n in nums)
            {
                pq.Enqueue(n, n);
                if(pq.Count > k)
                {
                    pq.Dequeue();
                }
            }
            return pq.Peek();
        }
    }
}
