using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class TwoSumSolver
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numsHash = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numsHash.ContainsKey(complement))
                {
                    return new int[] { numsHash[complement], i };
                }
                if (!numsHash.ContainsKey(nums[i]))
                {
                    numsHash[nums[i]] = i;
                }
            }
            return new int[0];
        }
    }
}