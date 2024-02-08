/* 1275 - Find Winner On A Tic Tac Toe.
   Topic - Array, Hash Table, Matrix, Simulation.
Tic - tac - toe is played by two players A and B on a 3 x 3 grid. The rules of Tic-Tac-Toe are:
Players take turns placing characters into empty squares ' '.
The first player A always places 'X' characters, while the second player B always places 'O' characters.
'X' and 'O' characters are always placed into empty squares, never on filled ones.
The game ends when there are three of the same (non-empty) character filling any row, column, or diagonal.
The game also ends if all squares are non-empty.
No more moves can be played if the game is over.
Given a 2D integer array moves where moves[i] = [rowi, coli] indicates that the ith move will be played on grid[rowi] [coli]. return the winner of the game if it exists (A or B). In case the game ends in a draw return "Draw". If there are still movements to play return "Pending".
You can assume that moves is valid (i.e., it follows the rules of Tic-Tac-Toe), the grid is initially empty, and A will play first.
Example 1:
Input: moves = [[0, 0],[2,0],[1,1],[2,1],[2,2]]
Output: "A"
Explanation: A wins, they always play first.
Example 2:
Input: moves = [[0, 0],[1,1],[0,1],[0,2],[1,0],[2,0]]
Output: "B"
Explanation: B wins.
Example 3:
Input: moves = [[0, 0],[1,1],[2,0],[1,0],[1,2],[2,1],[0,1],[0,2],[2,2]]
Output: "Draw"
Explanation: The game ends in a draw since there are no moves to make.
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.LeetCode_Solutions.Arrays_Hashing
{
    public class _1275_Find_Winner_On_A_Tic_Tac_Toe_Game
    {
        public _1275_Find_Winner_On_A_Tic_Tac_Toe_Game()
        {
            int[][] moves = new int[][]
            {
                new int[]{0,0},
                new int[]{2,0},
                new int[]{1,1},
                new int[]{2,1},
                new int[]{2,2}
            };
            int[][] move1 = new int[][]
           {
                new int[]{0,0},
                new int[]{1,1},
                new int[]{0,1},
                new int[]{0,2},
                new int[]{1,0},
                new int[]{2,0}
           };
            int[][] move2 = new int[][]
           {
                new int[]{0,0},
                new int[]{1,1},
                new int[]{2,0},
                new int[]{1,0},
                new int[]{1,2},
                new int[]{2,1},
                new int[]{0,1},
                new int[]{0,2},
                new int[]{2,2}
           };
            Console.WriteLine("Winner Of Tic Tac Toe = {0}", winnerOfTicTacToe(moves));
            Console.WriteLine("Winner Of Tic Tac Toe = {0}", winnerOfTicTacToe(move1));
            Console.WriteLine("Winner Of Tic Tac Toe = {0}", winnerOfTicTacToe(move2));
        }
        public string winnerOfTicTacToe(int[][] moves)
        {
            int[] rows = new int[3];
            int[] cols = new int[3];
            int diag = 0;
            int antidiag = 0;
            int player = 1;
            foreach(var move in moves)
            {
                int row = move[0];
                int col = move[1];
                rows[row] += player;
                cols[col] += player;
                if( row == col)
                {
                    diag += player;
                }
                if( row + col == 2)
                {
                    antidiag += player;
                }
                if(Math.Abs(rows[row]) == 3 || Math.Abs(cols[col]) == 3 || Math.Abs(diag) == 3 || Math.Abs(antidiag) == 3)
                {
                    return player == 1 ? "A" : "B";
                }
                player *= -1;
            }
            return moves.Length == 9 ? "Draw" : "Pending";
        }
    }
}
