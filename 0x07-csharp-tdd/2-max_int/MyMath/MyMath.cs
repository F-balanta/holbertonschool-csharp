using System;
using System.Collections.Generic;

namespace MyMath
{
    public class Operations
    {
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count <= 0)
                return 0;
            nums.Sort();
            int max = nums[nums.Count - 1];
            return max;
        }
    }
}