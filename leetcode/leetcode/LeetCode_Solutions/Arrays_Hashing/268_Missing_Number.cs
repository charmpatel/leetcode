using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _268_Missing_Number
    {
        public _268_Missing_Number()
        {
            int[] nums = new int[] { 3, 0, 1 };
            int[] num1 = new int[] { 0, 1 };
            int[] num2 = new int[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 };

            Console.WriteLine(missingNumber(nums));
            Console.WriteLine(missingNumber(num1));
            Console.WriteLine(missingNumber(num2));
        }
        public int missingNumber(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if (!hs.Contains(i))
                {
                    return i;
                }
            }
            return 0;
        }
    }
}
