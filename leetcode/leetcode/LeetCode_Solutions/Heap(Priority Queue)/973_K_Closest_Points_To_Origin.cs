/* 973 - K Closest Points To Origin.
   Topic - Array, Math, Divide and Conquer , Geometry, Sorting, Heap(PriorityQueue), Quickselect.
Given an array of points where points[i] = [xi, yi] represents a point on the X-Y plane and an integer k, return the k closest points to the origin (0, 0).
The distance between two points on the X-Y plane is the Euclidean distance (i.e., √(x1 - x2)2 + (y1 - y2)2).
You may return the answer in any order. The answer is guaranteed to be unique (except for the order that it is in).
Example 1:
Input: points = [[1, 3],[-2,2]], k = 1
Output:[[-2,2]]
Explanation:
The distance between(1, 3) and the origin is sqrt(10).
The distance between (-2, 2) and the origin is sqrt(8).
Since sqrt(8) < sqrt(10), (-2, 2) is closer to the origin.
We only want the closest k = 1 points from the origin, so the answer is just[[-2, 2]].
Example 2:
Input: points = [[3, 3],[5,-1],[-2,4]], k = 2
Output:[[3,3],[-2,4]]
Explanation: The answer[[-2,4],[3,3]] would also be accepted.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Heap_Priority_Queue_
{
    public class _973_K_Closest_Points_To_Origin
    {
        public _973_K_Closest_Points_To_Origin()
        {
            int[][] points = new int[][]
            {
                new int[] {1,3},
                new int[] {-2,2}
            };
            int k = 1;
            Console.WriteLine("K Closest Points To Origin {0}", kClosestToOrigin(points, k));
        }
        public int[][] kClosestToOrigin(int[][]points, int k)
        {
            PriorityQueue<int[], double> pq = new PriorityQueue<int[], double>();
            var res = new int[k][];
            for(int i = 0; i < points.Length; i++)
            {
                pq.Enqueue(points[i], getDistFromOrigin(points[i]));
            }
            for(int i = 0; i < k; i++)
            {
                res[i] = pq.Dqueue();
            }
            return res;
        }
        private static double getDistFromOrigin(int[] point)
        {
            return Math.Sqrt(Math.Pow(point[0], 2) + Math.Pow(point[1], 2));
        }
    }
}
