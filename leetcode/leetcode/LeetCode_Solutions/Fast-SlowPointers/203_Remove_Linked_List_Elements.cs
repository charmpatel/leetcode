/* 203 - Remove Linked List Elements.
Topic - Linked List, Recursion.
Given the head of a linked list and an integer val, remove all the nodes of the linked list that has Node.val == val, and return the new head.
Example 1:
Input: head = [1, 2, 6, 3, 4, 5, 6], val = 6
Output:[1,2,3,4,5]
Example 2:
Input: head = [], val = 1
Output:[]
Example 3:
Input: head = [7, 7, 7, 7], val = 7
Output:[]
*/

using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
    public class _203_Remove_Linked_List_Elements
    {
        public _203_Remove_Linked_List_Elements()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(6);
            l1.next.next.next = new ListNode(3);
            l1.next.next.next.next = new ListNode(4);
            l1.next.next.next.next.next = new ListNode(5);
            l1.next.next.next.next.next.next = new ListNode(4);

            ListNode head = RemoveElements(l1,4);
            PrintResult(head);
        }

        public void PrintResult(ListNode head)
        {
            while (head != null)
            {
                Console.WriteLine(head.val
                    + " ");
                head = head.next;
            }
            Console.WriteLine();
        }


        public static ListNode RemoveElements(ListNode head, int val)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode prev = dummy;
            ListNode curr = head;

            while (curr != null)
            {
                if (curr.val == val)
                    prev.next = curr.next;
                else
                    prev = curr;
                curr = curr.next;
            }
            return dummy.next;
        }
    }

}