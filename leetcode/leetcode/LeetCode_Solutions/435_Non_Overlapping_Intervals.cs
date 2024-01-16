using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions
{
    class _435_Non_Overlapping_Intervals
    {
        public _435_Non_Overlapping_Intervals()
        {
            int[][] arr =
            {
                new int[]{1,2},
                new int[]{2,3},
                new int[]{3,4},
                new int[]{1,3}
            };
            PrintResult(removeOverlapIntervals(arr));
            int[][] arr1 =
            {
                new int[]{1,2},
                new int[]{1,2},
                new int[]{1,2}
            };
            PrintResult(removeOverlapIntervals(arr1));

        }
        static void PrintResult(Object result)
        {
            Console.WriteLine("Starting _435_Non_Overlapping_Intervals");
            Console.WriteLine(result);
            Console.WriteLine("Ending _435_Non_Overlapping_Intervals");
        }
        /*Given an array of intervals intervals where intervals[i] = [starti, endi],
         * return the minimum number of intervals you need to remove to make the rest of the intervals non-overlapping. 

        Example 1:

        Input: intervals = [[1,2],[2,3],[3,4],[1,3]]
        Output: 1
        Explanation: [1,3] can be removed and the rest of the intervals are non-overlapping.
        Example 2:

        Input: intervals = [[1,2],[1,2],[1,2]]
        Output: 2
        Explanation: You need to remove two [1,2] to make the rest of the intervals non-overlapping.
        Example 3:

        Input: intervals = [[1,2],[2,3]]
        Output: 0
        Explanation: You don't need to remove any of the intervals since they're already non-overlapping.
                 * here we have to sort the intervals by start value.
                 * loop through into intervals and check if first int. last number is grater than secon int. fisrt num.
                 * then add counter 
                 * otherwise increse start value.
                 * at the end return couter value.
         */
        public static int removeOverlapIntervals (int[][] intervals)
        {
            Array.Sort(intervals, (a, b) => { return a[1] - b[1]; });
            int res = 0;
            int start = intervals[0][1];
            for(int i = 1; i < intervals.Length; i++)
            {
                if(intervals[i][0] < start)
                {
                    res++;
                }
                else
                {
                    start = intervals[i][1];
                }
            }
            return res;
        }
    }
}
