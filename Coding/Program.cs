using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Coding
{
    class Program
    {
        static void Main(string[] args)
        {
            //TwoSumCase();
            ThreeSumCase();
        }

        static void TwoSumCase()
        {
            var data = new int[] { 2, 11, 7, 15 };
            int target = 9;
            var twoSumS = new TwoSum.StraightSolution();
            var twoSumB = new TwoSum.BetterSolution();
            Console.WriteLine(string.Join(",", twoSumS.TwoSum(data, target)));
            Console.WriteLine(string.Join(",", twoSumB.TwoSum(data, target)));
            Console.ReadKey();
        }

        static void ThreeSumCase()
        {
            var data = new int[] { -1, 0, 1, 2, -1, -4 };
            var twoSumS = new ThreeSum.Solution();
            var answers = twoSumS.ThreeSum(data);
            foreach (var ans in answers)
            {
                Console.WriteLine(string.Join(",", ans));
            }
            Console.ReadKey();
        }


    }
}
