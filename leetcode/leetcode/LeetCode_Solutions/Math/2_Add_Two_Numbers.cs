/* 2 - Add Two  Numbers.
Topic - LinkedList,Math, Recursion.
You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.
You may assume the two numbers do not contain any leading zero, except the number 0 itself.
Example 1:
Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
Output:[7,0,8]
Explanation: 342 + 465 = 807.
Example 2:
Input: l1 = [0], l2 = [0]
Output:[0]
Example 3:
Input: l1 = [9, 9, 9, 9, 9, 9, 9], l2 = [9, 9, 9, 9]
Output:[8,9,9,9,0,0,0,1]
*/

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
