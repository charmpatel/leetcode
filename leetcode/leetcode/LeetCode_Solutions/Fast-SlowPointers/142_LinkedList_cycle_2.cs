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
