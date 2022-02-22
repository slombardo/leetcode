namespace leetcode.problems.FibonacciNumber
{
    public class Solution
    {
        public int Fib(int n)
        {
            if (n <= 1) return n;
            
            var first = 0;
            var second = 1;
            var third = 0;
            for (var i = 2; i <= n; i++)
            {
                third = first + second;
                first = second;
                second = third;
            }

            return third;
        }
    }
}