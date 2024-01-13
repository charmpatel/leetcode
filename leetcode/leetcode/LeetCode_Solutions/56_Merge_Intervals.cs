using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions
{
    public class _56_Merge_Intervals
    {
        public _56_Merge_Intervals()
        {
            int[][] array = new int[3][] { new int[] { 0, 30 }, new int[] { 5, 10 }, new int[] { 15, 20 } };
            PrintResult(Merge(array)); // TODO: Figure out how to print int[][] array
        }

        public void PrintResult(Object result)
        {
            Console.WriteLine("Starting _56_Merge_Intervals");
            Console.WriteLine(result);
            Console.WriteLine("Ending _56_Merge_Intervals");
        }

        public int[][] Merge(int[][] intervals)
        {
            int n = intervals.Length;
            if (intervals == null || n == 1)
            {
                return intervals;
            }
            Array.Sort(intervals, (a, b) => { return a[0] - b[0]; });
            List<int[]> res = new List<int[]>();
            int start = intervals[0][0];
            int end = intervals[0][1];
            for (int i = 1; i < n; i++)
            {
                if (end >= intervals[i][0])
                {
                    end = Math.Max(end, intervals[i][1]);
                }
                else
                {
                    res.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = intervals[i][1];
                }

            }
            res.Add(new int[] { start, end });
            return res.ToArray(); // int[][]
        }
                
    }
}
