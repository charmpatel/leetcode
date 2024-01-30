using leetcode.LeetCode_Solutions.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _148_Sort_List
    {
        public _148_Sort_List()
        {
            ListNode head = new ListNode(4);
            head.next = new ListNode(2);
            head.next.next = new ListNode(1);
            head.next.next.next = new ListNode(3);
            head.next.next.next.next = new ListNode(5);
            ListNode result = sortList(head);
            PrintResult(result);

        }
        public void PrintResult(ListNode result)
        {
            while (result != null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }
        }
    
        /*Given the head of a linked list, return the list after sorting it in ascending order.
        Example 1:
        Input: head = [4, 2, 1, 3]
        Output: [1,2,3,4]
        Example 2:
        Input: head = [-1, 5, 3, 4, 0]
        Output: [-1,0,3,4,5]
        Example 3:
        Input: head = []
        Output: []*/
        public ListNode sortList(ListNode head)
        {
            if (head == null)
                return null;

            var sorted = toSortedList(head);
            return buildList(sorted);
        }
        private List<int> toSortedList(ListNode head)
        {
            var res = new List<int>();
            while (head != null)
            {
                res.Add(head.val);
                head = head.next;
            }
            res.Sort();
            return res;
        }

        private ListNode buildList(List<int> list)
        {
            var root = new ListNode(list[0]);
            var curr = root;
            for (int i = 1; i < list.Count; i++)
            {
                curr.next = new ListNode(list[i]);
                curr = curr.next;
            }
            return root;
        }
    }
}
