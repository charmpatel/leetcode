﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
    public class _876_Middle_Of_The_LinkedList
    {
        public _876_Middle_Of_The_LinkedList()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
            l1.next.next.next.next.next = new ListNode(6);
            //l1.next.next.next.next.next.next = new ListNode(7);

            ListNode head = middleNode(l1);
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
        public ListNode middleNode(ListNode head)
        {
            if(head == null)
            {
                return null;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while(fast != null)
            {
                slow = slow.next;
                fast = fast.next;
                if(fast != null)
                {
                    fast = fast.next;
                }
            }
            return slow;
        }
    }
}
