/* 142 - Linked List Cycle 2.
Topic - Linked list, Two Pointers, Hash Table.
Given the head of a linked list, return the node where the cycle begins. If there is no cycle, return null.
There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to (0-indexed). It is -1 if there is no cycle. Note that pos is not passed as a parameter.
Do not modify the linked list.
Example 1:
Input: head = [3, 2, 0, -4], pos = 1
Output: tail connects to node index 1
Explanation: There is a cycle in the linked list, where tail connects to the second node.
Example 2:
Input: head = [1, 2], pos = 0
Output: tail connects to node index 0
Explanation: There is a cycle in the linked list, where tail connects to the first node.
Example 3:
Input: head = [1], pos = -1
Output: no cycle
Explanation: There is no cycle in the linked list.
*/

using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
    public class _142_LinkedList_cycle_2
    {
        public _142_LinkedList_cycle_2()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            l1.next.next.next.next.next = l1.next.next;
            ListNode head = DetectCycle(l1);
            if(head == null)
            {
                Console.WriteLine("No cycle detected");
            }
            else
            {
                Console.WriteLine("cycle detected at: {0}", head.val);
            }
            
        }
        public ListNode DetectCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                {
                    break;
                }
            }
            if (fast == null || fast.next == null)
            {
                return null;
            }
            while (head != fast)
            {
                head = head.next;
                fast = fast.next;
            }
            return head;
        }


    }
}
