using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Two_Pointers
{
    public class _15_3_Sum
    {
        public _15_3_Sum()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            int[] num1 = new int[] { 0,1,1 };
            int[] num2 = new int[] { 0,0,0};

           
            var result = threeSum(nums);
            var result1 = threeSum(num1);
            var result2 = threeSum(num2);

            //Console.WriteLine(PrintValue(result));

            /*private static int[] PrintValue(List<IList<int>> result)
            {
                for (int n = 0; n < result.Count; n++)
                {

                    // Print the row number 
                    Console.WriteLine("Row({0}): ", n);

                    for (int k = 0; k < result[n].Count; k++)
                    {

                        // Print the elements in the row 
                        Console.WriteLine("{0} ", result[n][k]);
                    }
                }
                Console.WriteLine("");
            }*/
            
            
            for (int n = 0; n < result1.Count; n++)
            {

                // Print the row number 
                Console.WriteLine("Row({0}): ", n);

                for (int k = 0; k < result1[n].Count; k++)
                {

                    // Print the elements in the row 
                    Console.WriteLine("{0} ", result1[n][k]);
                }
            }
            Console.WriteLine("");

            for (int n = 0; n < result2.Count; n++)
            {

                // Print the row number 
                Console.WriteLine("Row({0}): ", n);

                for (int k = 0; k < result2[n].Count; k++)
                {

                    // Print the elements in the row 
                    Console.WriteLine("{0} ", result2[n][k]);
                }
            }
            Console.WriteLine("");
        }
        public IList<IList<int>> threeSum(int[] nums)
        {
            int left, right;
            List<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);
            for(int i = 0; i < nums.Length; i++)
            {
                if(i > 0)
                {
                    if(nums[i] == nums[i - 1])
                    {
                        continue;
                    }
                }
                left = i + 1;
                right = nums.Length - 1;
                while(left < right)
                {
                    if(nums[i] + nums[left] + nums[right] > 0)
                    {
                        right--;
                    }
                    else if(nums[i] + nums[left] + nums[right] < 0)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while(nums[left] == nums[left - 1] && left < right)
                        {
                            left++;
                        }
                    }
                }
            }
            return res.ToArray();
        }
    }
}
