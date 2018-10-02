using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Given an array nums of n integers, are there elements a, b, c in nums such that "a + b + c = 0?"
//Find all unique triplets in the array which gives the sum of zero.
//Note:
//The solution set must not contain duplicate triplets.
//Example:
//Given array nums = [-1, 0, 1, 2, -1, -4],
//A solution set is:
//[
//  [-1, 0, 1],
//  [-1, -1, 2]
//]
namespace ThreeSum
{
    //Idea : Select one first ,  then select the other two like TwoSum
    //Loop it , but have to prevent the duplicate.

    //How to solve duplicate case ? distinct? 
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            //Array.Sort(nums);
            var ans = new List<IList<int>>();
            for (var i = 0; i < nums.Length; i++)
            {
                var data = nums.Where(a => a != nums[i]).ToArray();
                var x = TwoSum(data, -nums[i], i, nums[i]);
                if (x.Count() > 0)
                {
                    if (!ans.Any(a => a == x))
                    {
                        ans.AddRange(x);
                    }
                }
            }
            return ans.Distinct().ToArray();
        }

        public IList<IList<int>> TwoSum(int[] nums, int target, int selectIndex, int selectNumber)
        {
            var firstAns = new List<IList<int>>();
            var dic = new Dictionary<int, int>();
            for (var i = selectIndex; i < nums.Length; i++)
            {
                int Remainder = target - nums[i];
                if (dic.ContainsKey(Remainder))
                {
                    firstAns.Add(new int[] { Remainder, nums[i], selectNumber });
                    //return new int[] { Remainder, nums[i], selectNumber };
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            return firstAns.ToArray();
        }
    }


}
