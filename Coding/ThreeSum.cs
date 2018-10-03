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
    //       Loop it , but have to prevent the duplicate case.

    //Result : 313 / 313 test cases passed.
    //Status: Memory Limit Exceeded
    //Submitted: 0 minutes ago
    //All case passed but Memory Limit Exceeded.....nooooo
    //不知道為什麼空間複雜度使用超過限制
    //因為呼叫了n次 twoSum 空間O(n) 變成了 O{n^2)?
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            //Sort first
            Array.Sort(nums);
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                //remove pickOne
                var data = nums.Where((val, index) => index > i).ToArray();
                var partAnswers = TwoSum(data, -nums[i]);
                if (partAnswers.Count() > 0)
                {
                    foreach (var answer in partAnswers)
                    {
                        result.Add(answer);
                    }
                }
            }
            return result;
        }
        public IList<IList<int>> TwoSum(int[] nums, int target)
        {
            IList<IList<int>> firstAns = new List<IList<int>>();
            var dic = new Dictionary<int, int>();
            // prePick solve duplicate case  
            int? prePick = null;
            for (var i = 0; i < nums.Length; i++)
            {
                //solve [0,0,0,0+] case
                if (i > 1 && nums[i] == nums[i - 2])
                    continue;
                int Remainder = target - nums[i];
                if (dic.ContainsKey(Remainder))
                {
                    if (nums[i] != prePick)
                    {
                        firstAns.Add(new int[] { Remainder, nums[i], -target });
                    }
                    prePick = nums[i];
                }
                else
                {
                    dic[nums[i]] = i;
                }
            }
            return firstAns;
        }
    }







    //參考JAVA版本  O(N^2)
    //Idea : Select one first ,  then select the other 
    //not using twoSum
    //Submission Result: Accepted 

    public class Solution2
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            //Sort first  
            Array.Sort(nums);

            //Select one first
            for (var i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                int start = i + 1, end = nums.Length - 1, target = -nums[i];
                //Approach from both end
                while (start < end)
                {
                    if (nums[start] + nums[end] == target)
                    {
                        result.Add(new int[] { nums[start], nums[end], -target });
                        //skip the same numbers if added
                        while (start < end && nums[start] == nums[start + 1]) start++;
                        while (start < end && nums[end] == nums[end - 1]) end--;
                        start++; end--;
                    }
                    else if (nums[start] + nums[end] < target)
                        start++;
                    else
                        end--;
                }
            }
            return result;
        }
    }
}
