using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _143_Reorder_List
    {
        public _143_Reorder_List()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);
            recorderList(head);
            PrintResult(head);
        }
        public void PrintResult(ListNode result)
        {
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
        /*You are given the head of a singly linked-list.The list can be represented as:
        L0 → L1 → … → Ln - 1 → Ln
        Reorder the list to be on the following form:
        L0 → Ln → L1 → Ln - 1 → L2 → Ln - 2 → …
        You may not modify the values in the list's nodes. Only nodes themselves may be changed.
        Example 1:
        Input: head = [1,2,3,4]
                Output: [1,4,2,3]
        Example 2:
        Input: head = [1,2,3,4,5]
        Output: [1,5,2,4,3]*/

        public void recorderList(ListNode head)
        {
            if (head == null || head.next == null)
                return;
            var slow = head;
            var fast = head.next;

            while(fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode second = slow.next;
            slow.next = null;

            ListNode prev = null;
            while(second != null)
            {
                var next = second.next;
                second.next = prev;
                prev = second;
                second = next;
            }
            second = prev;
            var first = head;
            while(second != null)
            {
                (var firstnext, var secondnext) = (first.next, second.next);
                first.next = second;
                second.next = firstnext;
                first = firstnext;
                second = secondnext;
            }
        }
    }
}
