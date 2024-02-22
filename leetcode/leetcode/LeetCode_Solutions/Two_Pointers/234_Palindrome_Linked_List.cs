/*234- Palindrome Linked List
 Topic - Two Pointers, Linked List, Stack, Recursion.
Given the head of a singly linked list, return true if it is a palindrome or false otherwise.
Example 1:
Input: head = [1,2,2,1]
Output: true
Example 2:
Input: head = [1,2]
Output: false
*/

using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _234_Palindrome_Linked_List
    {
        public _234_Palindrome_Linked_List()
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(2);
            head.next.next.next = new ListNode(1);
            Console.Write("234_Palindrome_Linked_List is: {0}", isPalindrome(head));
            Console.WriteLine("");

        }
        
        

        public bool isPalindrome(ListNode head)
        {
            var slow = head;
            var fast = head;
            ListNode prev = null;

            //reverse first half of the list
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            //if list has odd number of elements skip middle element
            if (fast != null)
                slow = slow.next;

            //compare first and second half of the list
            while (slow != null)
            {
                if (slow.val != prev.val)
                    return false;

                slow = slow.next;
                prev = prev.next;
            }

            return true;
        }
    }
}
