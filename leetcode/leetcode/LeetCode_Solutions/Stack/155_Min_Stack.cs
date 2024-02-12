/* 155 - Min Stack
 * Topic - Stack, Design.
Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
Implement the MinStack class:
MinStack() initializes the stack object.
void push(int val) pushes the element val onto the stack.
void pop() removes the element on the top of the stack.
int top() gets the top element of the stack.
int getMin() retrieves the minimum element in the stack.
You must implement a solution with O(1) time complexity for each function.
Example 1:
Input
["MinStack", "push", "push", "push", "getMin", "pop", "top", "getMin"]
[[],[-2],[0],[-3],[],[],[],[]]

Output
[null, null, null, null, -3, null, 0, -2]

Explanation
MinStack minStack = new MinStack();
minStack.push(-2);
minStack.push(0);
minStack.push(-3);
minStack.getMin(); // return -3
minStack.pop();
minStack.top();    // return 0
minStack.getMin(); // return -2*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Sliding_Window
{
    public class _155_Min_Stack
    {
        
        Stack<int> stack = null;
        Stack<int> minstack = null;
        int minval = 0;
        public _155_Min_Stack()
        {
            stack = new Stack<int>();
            minstack = new Stack<int>();
            //_155_Min_Stack(-2));

        }
        
        public void Push(int val)
        {
            if(stack.Count == 0)
            {
                minval = val;
            }
            stack.Push(val);
            minval = Math.Min(minval, val);
            minstack.Push(minval);
        }

        public void pop()
        {
            stack.Pop();
            minstack.Pop();
            if(minstack.Count > 0)
            {
                minval = minstack.Peek();
            }
        }
        public int top()
        {
            return stack.Peek();
        }
        public int GetMin()
        {
            return minval;
        }
    }
}
