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
