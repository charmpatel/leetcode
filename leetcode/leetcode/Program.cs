using leetcode.LeetCode_Solutions;
using leetcode.LeetCode_Solutions.Merge_Intervals;
using leetcode.LeetCode_Solutions.Fast_SlowPointers;
using leetcode.LeetCode_Solutions.Tree_Dfs;
using leetcode.LeetCode_Solutions.Two_Pointers;
using leetcode.LeetCode_Solutions.Utility;
using leetcode.LeetCode_Solutions.Arrays_Hashing;
using leetcode.LeetCode_Solutions.Sliding_Window;
//using leetcode.LeetCode_Solutions.Heap_Priority_Queue_;
using System;
using System.Collections.Generic;
using leetcode.LeetCode_Solutions.Arrays;
using leetcode.LeetCode_Solutions.Binary_Search;
using leetcode.LeetCode_Solutions.Dynamic_Programming;
using leetcode.LeetCode_Solutions.String;

namespace leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Merge Intervals Pattern");

           /* _56_Merge_Intervals mergeIntervals = new _56_Merge_Intervals();
            _253_Meeting_Rooms_2 meetingRooms2 = new _253_Meeting_Rooms_2();
            _252_Meeting_Rooms canAttendMeeting = new _252_Meeting_Rooms();
            _435_Non_Overlapping_Intervals removeOverlapIntervals = new _435_Non_Overlapping_Intervals();*/
            Console.WriteLine("Ending Merge Intervals Pattern");
            
            Console.WriteLine("Starting Fast and Slow Pointers");
            /*_2_Add_Two_Numbers add_Two_Numbers = new _2_Add_Two_Numbers();
            _19_Remove_nth_Node removeNthFromEnd = new _19_Remove_nth_Node();
            _83_Remove_Duplicates_From_SortedList deleteDuplicates = new _83_Remove_Duplicates_From_SortedList();
            _141_Linked_List_Cycle linkedListCycle = new _141_Linked_List_Cycle();
            _142_LinkedList_cycle_2 detectCycle = new _142_LinkedList_cycle_2();
            _203_Remove_Linked_List_Elements RemoveElement = new _203_Remove_Linked_List_Elements();
            _876_Middle_Of_The_LinkedList subLinkedList = new _876_Middle_Of_The_LinkedList();
            _143_Reorder_List reorderList = new _143_Reorder_List();
            _21_Merge_Two_Sorted_List megetwolists = new _21_Merge_Two_Sorted_List();*/
            Console.WriteLine("Ending Fast and Slow Pointers");

            Console.WriteLine("Starting Tree Dfs");
            /*_98_Validate_Binary_Search_Tree isValidBST = new _98_Validate_Binary_Search_Tree();
            _100_Same_Tree isTreePalindrome = new _100_Same_Tree();
            _104_Maximum_Depth_of_Binary_Tree maxDepthBT = new _104_Maximum_Depth_of_Binary_Tree();
            _112_Path_Sum isPathSum = new _112_Path_Sum();
            _113_Path_Sum_2 pathSumNodeVal = new _113_Path_Sum_2();
            _124_Binary_Tree_Maximum_Path_Sum maxPathSum = new _124_Binary_Tree_Maximum_Path_Sum();
            _1448_Count_Good_Nodes_In_Binary_Tree countGoodNodes = new _1448_Count_Good_Nodes_In_Binary_Tree();*/
            Console.WriteLine("Ending Tree Dfs");

            Console.WriteLine("Starting Arrays");
            /*_54_Spiral_Matrix traversMatrix = new _54_Spiral_Matrix();
            _1_Two_Sum twoSum = new _1_Two_Sum();
            _359_Logger_Rate_Limiter isMessagePrint = new _359_Logger_Rate_Limiter();
            _1763_Longest_Nice_Substring longestSubstring = new _1763_Longest_Nice_Substring();
            _268_Missing_Number missingNumber = new _268_Missing_Number();
            _287_Find_the_Duplicate_Number findDuplicateNumber = new _287_Find_the_Duplicate_Number();
            _348_Design_Tic_Tac_Toe tic_Tac_Toe = new _348_Design_Tic_Tac_Toe(3);
            _49_Group_Anagram grpAnagram = new _49_Group_Anagram();
            _242_Valid_Anagram validAnagram = new _242_Valid_Anagram();
            _347_Top_K_Frequent_Elements findKthElements = new _347_Top_K_Frequent_Elements();
            _266_Palindrome_Permutation permutePalindrome = new _266_Palindrome_Permutation();
            _1822_Sign_Of_the_Product_Of_An_Array signOfArray = new _1822_Sign_Of_the_Product_Of_An_Array();
            _1304_Find_N_Unique_Integers_Sum_UpTo_Zero uniqueIntSumZero = new _1304_Find_N_Unique_Integers_Sum_UpTo_Zero();
            _217_Contains_Duplicate containsDuplicate = new _217_Contains_Duplicate();
            _202_Happy_Number isHappyNum = new _202_Happy_Number();
            _66_Plus_One plusOne = new _66_Plus_One();
            _769_Max_Chunks_To_Make_Sorted maxChunks = new _769_Max_Chunks_To_Make_Sorted();*/
            _1275_Find_Winner_On_A_Tic_Tac_Toe_Game winnerOfTicTacToe = new _1275_Find_Winner_On_A_Tic_Tac_Toe_Game();

            Console.WriteLine("Ending Arrays");

            Console.WriteLine("Starting Two_Pointers");
            /*_15_3_Sum ThreeSum = new _15_3_Sum();
            _125_Valid_Palindrome isPalindrome = new _125_Valid_Palindrome();
            _283_Move_Zeroes moveZeroesAtEnd = new _283_Move_Zeroes();
            _11_Container_With_Most_Water maxAmountWater = new _11_Container_With_Most_Water();
            _234_Palindrome_Linked_List palindrome_Linked_List = new _234_Palindrome_Linked_List();
            _148_Sort_List sortList = new _148_Sort_List();
            _1_Two_Sum_Sorted_Array twoSumSortedArray = new _1_Two_Sum_Sorted_Array();*/
            _344_Reverse_String reverse_String = new _344_Reverse_String();
            _345_Reverse_Volwels_Of_A_String reverseVolwels = new _345_Reverse_Volwels_Of_A_String();
           
            Console.WriteLine("Ending Two Pointers");

            Console.WriteLine("Starting Sliding Windows");
            /*_3_Longest_Substring_Without_Repeating_characters longestSubstringUniquechar = new _3_Longest_Substring_Without_Repeating_characters();
            _155_Min_Stack getMinStackVal = new _155_Min_Stack();
            getMinStackVal.Push(-2);
            getMinStackVal.Push(0);
            getMinStackVal.Push(-3);
            Console.WriteLine("Get Minimum Val of Stack {0} ", getMinStackVal.GetMin()); // return -3
            getMinStackVal.pop();
            getMinStackVal.top();    // return 0
            Console.WriteLine("Get Minimum Val of Stack {0} ", getMinStackVal.GetMin()); // return -2

            _150_Evaluate_Reverse_Polish_Notation reversearithmeticExpression = new _150_Evaluate_Reverse_Polish_Notation();
            _20_Valid_Parentheses validParenth = new _20_Valid_Parentheses();
            _680_Valid_Palindrome_2 isValidPalindrome2 = new _680_Valid_Palindrome_2();*/
            _424_Longest_Repeating_Character_Replacement Longest_Repeating_Char = new _424_Longest_Repeating_Character_Replacement();
            Console.WriteLine("Ending Sliding Windows");

            Console.WriteLine("Starting Binary Search");
            /*_704_Binary_Search binarySearchAlgo = new _704_Binary_Search();
            _153_Find_Minimum_In_Rotated_Sorted_Array minRotatedSortedArray = new _153_Find_Minimum_In_Rotated_Sorted_Array();
            _74_Search_A_2D_Matrix search2DMatrix = new _74_Search_A_2D_Matrix();
            _33_Search_In_Rotated_Sorted_Array searchInRotatedSortedArray = new _33_Search_In_Rotated_Sorted_Array();*/
            Console.WriteLine("Ending Binary Search");

            Console.WriteLine("Starting Priority Queue");
            /*_703_KTh_Largest_Element_In_A_Stream KthLargestEleInStream = new _703_KTh_Largest_Element_In_A_Stream();
            _215_KTh_Largest_Element_In_An_Array findKthEleInArray = new _215_KTh_Largest_Element_In_An_Array();
            _1046_Last_Stone_Weight lastStoneWeight = new _1046_Last_Stone_Weight();
            _973_K_Closest_Points_To_Origin KClosestPointsToOrigin = new _973_K_Closest_Points_To_Origin();*/
            Console.WriteLine("Ending Priority Queue");

            Console.WriteLine("Starting Dynamic Programming");
            /*_198_House_Robber houseRobber = new _198_House_Robber();
            _213_House_Robber_2 houseRobber2 = new _213_House_Robber_2();
            _70_Climbing_Stairs climbingStairs = new _70_Climbing_Stairs();
            _746_Min_Cost_Climbing_Stairs minCostClimbingStairs = new _746_Min_Cost_Climbing_Stairs();
            _300_Longest_Increasing_Subsequence LongestIncreasingSubsequence = new _300_Longest_Increasing_Subsequence();
            _322_Coin_Change coinChange = new _322_Coin_Change();*/
            Console.WriteLine("Ending Dynamic Programming");

            Console.WriteLine("Starting String");
           /* _948_String_Without_AAA_Or_BBB stringWithout3A3B = new _948_String_Without_AAA_Or_BBB();
            _1647_Minimum_Deletion_To_Make_char_unique minCharFreqUnique = new _1647_Minimum_Deletion_To_Make_char_unique();*/
            Console.WriteLine("Ending String");
        }
    }
}
