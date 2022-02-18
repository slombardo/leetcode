using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.ClimbingStairs
{
    public class Solution
    {
        /// <summary>
        /// Using Fibonacci sequence
        /// </summary>
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            var first = 1;
            var second = 2;
            var third = 0;
            for (var i = 3; i <= n; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }

            return third;
        }
    }

    public class Solution2
    {
        /// <summary>
        /// Times out on leetcode, but was fun to figure out!!!
        /// </summary>
        public int ClimbStairs(int n)
        {
            if (n <= 2) return n;

            var totalWays = 1;
            var totalTwos = 0;
            var steps = new List<int>();

            for (var i = 0; i < n; i++)
            {
                steps.Add(1);
            }

            while (steps.Take(n / 2).Any(x => x == 1))
            {
                // see if all the twos are at the front
                while (steps.Take(totalTwos).Any(x => x != 2))
                {
                    Bump(steps);
                    totalWays++;
                }

                steps.Reverse();

                // see if the first 2 has a two, if so, we're done
                if (steps.Take(2).Any(x => x == 2)) break;

                // remove 2 ones
                steps.RemoveAt(0);
                steps.RemoveAt(0);
                steps.Add(2);
                totalTwos++;
                totalWays++;
            }

            return totalWays;
        }

        private static void Bump(List<int> steps)
        {
            // find the position of the last 2
            var pos = steps.LastIndexOf(2);
            var lookBehind = 1;

            while (steps[pos - lookBehind] == 2)
            {
                lookBehind++;
            }

            // remove the next 1
            steps.RemoveAt(pos - lookBehind);

            // add the 1 where the 2 was
            steps.Insert(pos - (lookBehind - 1), 1);

            if (lookBehind <= 1) return;

            // send all non-bumped 2's back to the beginning if there was at least one 2 in front

            var twosToReturnToBottom = (lookBehind - 2);

            for (var i = 0; i <= twosToReturnToBottom; i++)
            {
                steps.RemoveAt(pos - twosToReturnToBottom);
                steps.Add(2);
            }
        }
    }
}