/* 83 - Remove Duplicates From SortedList
Topic - Linked List.
Given the head of a sorted linked list, delete all duplicates such that each element appears only once. Return the linked list sorted as well.
Example 1:
Input: head = [1, 1, 2]
Output:[1,2]
Example 2:
Input: head = [1, 1, 2, 3, 3]
Output:[1,2,3]
*/

using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
    public class _83_Remove_Duplicates_From_SortedList
    {
        public _83_Remove_Duplicates_From_SortedList()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(1);
            l1.next.next = new ListNode(2);
            l1.next.next.next = new ListNode(3);
            l1.next.next.next.next = new ListNode(3);
            l1.next.next.next.next.next = new ListNode(4);
            l1.next.next.next.next.next.next = new ListNode(4);

            ListNode head = deleteDuplicates(l1);
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

        public ListNode deleteDuplicates(ListNode head)
        {
            if(head != null)
            {
                ListNode current = head;
                while(current.next != null)
                {
                    if(current.val == current.next.val)
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
            }
            return head;
        }
    }
}
