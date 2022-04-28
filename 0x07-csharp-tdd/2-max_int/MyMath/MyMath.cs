using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// This method contains a matemathics operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// This method public search  the biggest number of a list
        /// </summary>
        /// <param name="nums">Values to evaluate</param>
        /// <returns>This method public return  the biggest number of a list</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count > 0)
            {
                nums.Sort();
                int max = nums[nums.Count - 1];
                return max;
            }
            else
                return 0;

        }
    }
}