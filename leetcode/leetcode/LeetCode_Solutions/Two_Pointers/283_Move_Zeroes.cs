using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _283_Move_Zeroes
    {
        public _283_Move_Zeroes()
        {
            int[] num1 = new int[] { 0, 1, 0, 3, 12 };
            //var res = moveZeroes(num1);
          /* for(int i = 0; i< res.Length;i++)
            {
                Console.Write("{0} ", res[i]);
            }
            Console.WriteLine(" ");*/
        }
        /*Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
        Note that you must do this in-place without making a copy of the array.
        Example 1:

        Input: nums = [0, 1, 0, 3, 12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]*/

        public void moveZeroes(int[] nums)
        {
            int left = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] != 0)
                {
                    int temp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = temp;
                    left++;
                }
            }
        }
    }
}
