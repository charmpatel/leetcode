/* 704 - Kth Largest Element in a Stream
   Topic - Heap(Priority Queue), Tree, Binary Search Tree, Data Stream, Binary Tree, Design.
Design a class to find the kth largest element in a stream. Note that it is the kth largest element in the sorted order, not the kth distinct element.
Implement KthLargest class:
KthLargest(int k, int[] nums) Initializes the object with the integer k and the stream of integers nums.
int add(int val) Appends the integer val to the stream and returns the element representing the kth largest element in the stream.
Example 1:
Input
["KthLargest", "add", "add", "add", "add", "add"]
[[3, [4, 5, 8, 2]], [3], [5], [10], [9], [4]]
Output
[null, 4, 5, 5, 8, 8]
Explanation
KthLargest kthLargest = new KthLargest(3, [4, 5, 8, 2]);
kthLargest.add(3);   // return 4
kthLargest.add(5);   // return 5
kthLargest.add(10);  // return 5
kthLargest.add(9);   // return 8
kthLargest.add(4);   // return 8
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Heap_Priority_Queue_
{
    public class _703_KTh_Largest_Element_In_A_Stream
    {
        int temp;
        PriorityQueue<int, int> pq;
        public _703_KTh_Largest_Element_In_A_Stream(int k, int[] nums ) 
        {
            this.temp = k;
            pq = new PriorityQueue<int, int>();
            foreach(int num in nums)
            {
                Add(num);
            }
        }
        
        public int Add(int val)
        {
            pq.Enqueue(val, val);
            if(pq.Count > temp)
            {
                pq.Dequeue();
            }
            return pq.Peek();
        }
    }
}
