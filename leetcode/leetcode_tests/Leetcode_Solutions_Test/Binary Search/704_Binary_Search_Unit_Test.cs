using System;
using System.Collections.Generic;
using System.Text;
using leetcode.LeetCode_Solutions.Binary_Search;
using NUnit.Framework;


namespace leetcode_tests.Leetcode_Solutions_Test.Binary_Search
{
    class _704_Binary_Search_Unit_Test
    {
        _704_Binary_Search binary_search;
        int[] nums;
        int target ;
        [SetUp]
        public void SetUp()
        {
            binary_search = new _704_Binary_Search();
        }
        
        [Test]
        public void BinarySearchItemFoundTest()
        {
            target = 0;
            nums  = new int[] { -1, 0, 3, 5, 9, 12 }; 
            int result = binary_search.Search(nums, target);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void BinarySearchItemNotFoundTest()
        {
            target = 100;
            nums = new int[] { -1, 0, 3, 5, 9, 12 };
            int result = binary_search.Search(nums, target);
            Assert.AreEqual(-1, result);
        }
    }
}
