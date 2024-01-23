using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
    
    public class _19_Remove_nth_Node
    {
        public _19_Remove_nth_Node()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);
            l1.next.next = new ListNode(3);
            l1.next.next.next = new ListNode(4);
            l1.next.next.next.next = new ListNode(5);
           
            ListNode head = removeNthFromEnd(l1,4);
            PrintResult(head);
        }

        public void PrintResult(ListNode head)
        {
            ListNode result = head;
            while (result != null)
            {
                Console.WriteLine(result.val
                    + " ");
                result = result.next;
            }
            Console.WriteLine();
        }

        public ListNode removeNthFromEnd(ListNode head, int n)
        {
            ListNode slow = head;
            ListNode fast = head;

            for(int i = 0; i<n; i++)
            {
                fast = fast.next;
            }
            if(fast == null)
            {
                return head.next;
            }
            while(fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}
