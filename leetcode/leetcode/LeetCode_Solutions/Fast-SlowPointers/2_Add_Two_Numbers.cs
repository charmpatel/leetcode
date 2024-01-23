using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Fast_SlowPointers
{
   

    public class _2_Add_Two_Numbers
    {
        public _2_Add_Two_Numbers()
        {
            ListNode l1 = new ListNode(2) ;
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            ListNode result = AddTwoNumbers(l1, l2);
            PrintResult(result);
        }

        public void PrintResult(ListNode result)
        {
            while(result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {


            ListNode dummyNode = new ListNode(0);
            ListNode current = dummyNode;
            int carry = 0;

            while (l1 != null || l2 != null || carry != 0)
            {
                int x = (l1 != null) ? l1.val : 0; //3
                int y = (l2 != null) ? l2.val : 0; // 4
                int sum = x + y + carry; //8
                carry = sum / 10; // 8/10 --> 0 
                current.next = new ListNode(sum % 10); // 8%10 ==8 
                current = current.next; // 7

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

            }
            return dummyNode.next;
        }
    }
}
