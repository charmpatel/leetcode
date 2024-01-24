using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays
{
    public class _348_Design_Tic_Tac_Toe
    {
        int[] rows;
        int[] cols;
        int diag;
        int antidiag;
        int N;
        public  _348_Design_Tic_Tac_Toe(int n)
        {
            rows = new int[n];
            cols = new int[n];
            diag = 0;
            antidiag = 0;
            N = n;

            int[][] arr = new int[][]
            {
                new int[] { 0, 0, 1},
                new int[] { 0, 2, 2},
                new int[] { 2, 2, 1},
                new int[] { 1, 1, 2},
                new int[] { 2, 0, 1},
                new int[] { 1, 0, 2},
                new int[] { 2, 1, 1}
            };

            Console.WriteLine(Move(0, 0, 1));
            Console.WriteLine(Move(0, 2, 2));
            Console.WriteLine(Move(2, 2, 1));
            Console.WriteLine(Move(1, 1, 2));
            Console.WriteLine(Move(2, 0, 1));
            Console.WriteLine(Move(1, 0, 2));
            Console.WriteLine(Move(2, 1, 1));
        }
        
       
        public int Move(int row, int col, int player)
        {
            var playerNumber = player == 1 ? 1 : -1;
            rows[row] += playerNumber;
            cols[col] += playerNumber;

            if (Math.Abs(row - col) == 0)
                diag += playerNumber;
            if (row + col == N - 1)
                antidiag += playerNumber;
            if (Math.Abs(rows[row]) == N || Math.Abs(cols[col]) == N || Math.Abs(diag) == N || Math.Abs(antidiag) == N)
                return playerNumber == 1 ? 1 : 2;

            return 0;
        }
    }
}
