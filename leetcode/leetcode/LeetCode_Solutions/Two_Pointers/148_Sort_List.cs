/* 148 - Sort List
Topic - Linked List,Two Pointer, Divide and Conquer, Sorting, Merge Sort.
Given the head of a linked list, return the list after sorting it in ascending order.
Example 1:
Input: head = [4, 2, 1, 3]
Output: [1,2,3,4]
Example 2:
Input: head = [-1, 5, 3, 4, 0]
Output: [-1,0,3,4,5]
Example 3:
Input: head = []
Output: []
*/

using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _148_Sort_List
    {
        public _148_Sort_List()
        {
            ListNode head = new ListNode(4);
            head.next = new ListNode(5);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(2);
            ListNode result = sortList(head);
            PrintResult(result);

        }
        public void PrintResult(ListNode result)
        {
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
        public ListNode sortList(ListNode head)
        {
            var list = new List<int>();
            while(head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            list.Sort();
            var curr = new ListNode();
            var p = curr;
            for(int i = 0; i < list.Count; i++)
            {
                p.next = new ListNode(list[i]);
                p = p.next;
            }
            return curr.next;
        }
    }
}
