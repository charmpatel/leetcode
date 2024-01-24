using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _54_Spiral_Matrix
    {
        public _54_Spiral_Matrix()
        {
           
        }
        public IList<int> spiralMatrix(int[][] matrix)
        {
            IList<int> res = new List<int>();
            int startrow = 0;
            int startcol = 0;
            int endrow = matrix[0].Length - 1;
            int endcol = matrix.Length - 1;
            while(startrow <= endrow && startcol <= endcol)
            {
                for(int i = startrow; i <= endrow; i++)
                {
                    res.Add(matrix[startcol][i]);
                }
                startcol++;
                if (startcol > endcol)
                    break;
                for (int j = startcol; j <= endcol; j++)
                {
                    res.Add(matrix[j][endrow]);
                }
                endrow--;
                if (startrow > endrow)
                    break;
                for(int k = endrow; k >= startrow; k--)
                {
                    res.Add(matrix[endcol][k]);
                }
                endcol--;
                if (startcol > endcol)
                    break;
                for (int m = endcol; m >= startcol; m-- ){
                    res.Add(matrix[m][startrow]);
                }
                startrow++;
                if (startrow > endrow)
                    break;
            }
            return res;
        }

    }
}
