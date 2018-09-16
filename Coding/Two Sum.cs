using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given an array of integers, return indices of the two numbers such that they add up to a specific target.
//You may assume that each input would have exactly one solution, and you may not use the same element twice.
//Example:
//Given nums = [2, 7, 11, 15], target = 9,
//Because nums[0] + nums[1] = 2 + 7 = 9,
//return [0, 1].
namespace TwoSum
{
    //easy -way O(n^2)
    public class StraightSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && i != j)
                    {

                        return new int[] { i, j };
                    }
                }
            }
            throw new Exception("No Match Result!");
        }
    }

    //Keep find the Remainder in the Dictionary
    //Add the number as key & addr as value if not found
    public class BetterSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                int Remainder = target - nums[i];
                if (dic.ContainsKey(Remainder))
                {
                    return new int[] { dic[Remainder], i };
                }
                dic[nums[i]] = i;
            }
            throw new Exception("No Match Result!");
        }
    }
}
