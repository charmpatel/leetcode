/*1304 - Find N Unique Integers Sum Up To Zero
  Topic - Array, Math.
 
Given an integer n, return any array containing n unique integers such that they add up to 0.
Example 1:
Input: n = 5
Output:[-7,-1,1,3,4]
Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
Example 2:
Input: n = 3
Output:[-1,0,1]
Example 3:
Input: n = 1
Output:[0]
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _1304_Find_N_Unique_Integers_Sum_UpTo_Zero
    {
        public _1304_Find_N_Unique_Integers_Sum_UpTo_Zero()
        {
            int n = 6;
            var res = intSumUptoZero(n);
            Console.Write(" N Unique Int Sum Upto Zero  ");
            foreach (var i in res)
            {
                Console.Write( i);
            }
            Console.WriteLine("");

        }

        /*Seudo code-
            create a list to return it.
            loop through in n to create a array. with n/2
            add i and -i 
            if n %2 !=0 then add 0.(if num is odd then add 0).
            List convert it in array and return it.
*/
        public int[] intSumUptoZero(int n)
        {
            var list = new List<int>();
            for(int i = 1; i <= n/2; i++)
            {
                list.Add(i);
                list.Add(-i);
            }
            if(n % 2 != 0)
            {
                list.Add(0);
            }
            return list.ToArray();
        }
    }
}
