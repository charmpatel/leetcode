/* 21 -Merge Two Sorted List
Topic - LinkedList, Recursion.
You are given the heads of two sorted linked lists list1 and list2.
Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
Return the head of the merged linked list.
Example 1:
Input: list1 = [1, 2, 4], list2 = [1, 3, 4]
Output:[1,1,2,3,4,4]
Example 2:
Input: list1 = [], list2 = []
Output:[]
Example 3:
Input: list1 = [], list2 = [0]
Output:[0]
*/

using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
    public class _21_Merge_Two_Sorted_List
    {
        public _21_Merge_Two_Sorted_List()
        {
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);
            ListNode list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);
            ListNode result =  mergedTwoList(list1, list2);
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
        public ListNode mergedTwoList( ListNode list1, ListNode list2)
        {
            var dummy = new ListNode();
            var res = dummy;
            var p1 = list1;
            var p2 = list2;
            while(p1 != null && p2 != null)
            {
                if(p1.val < p2.val)
                {
                    res.next = p1;
                    p1 = p1.next;
                }
                else
                {
                    res.next = p2;
                    p2 = p2.next;
                }
                res = res.next;
            }
            res.next = p1 ?? p2;
            return dummy.next;
        }
    }
}
