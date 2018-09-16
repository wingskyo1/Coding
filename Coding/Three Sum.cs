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
namespace TwoSum
{
    //Idea : Select one first , and the select the other two like TwoSum
    //Loop it , but have to prevent the duplicate.
    public class StraightSolution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();

            return ans;
        }
    }

   
}
