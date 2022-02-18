using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ClimbingStairs
{
    public static class ClimbingStairsTest
    {
        public class ClimbingStairsExpectations
        {
            public int N { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData =
        {
            new ClimbingStairsExpectations
            {
                N = 1,
                Expectation = 1
            },
            new ClimbingStairsExpectations
            {
                N = 2,
                Expectation = 2
            },
            new ClimbingStairsExpectations
            {
                N = 3,
                Expectation = 3
            },
            new ClimbingStairsExpectations
            {
                /*
                 * 1. 1111
                 * 2. 112
                 * 3. 121
                 * 4. 211
                 * 5. 22
                 */
                N = 4,
                Expectation = 5
            },
            new ClimbingStairsExpectations
            {
                /* 
                 * 1. 11111
                 * 2. 1112
                 * 3. 1121
                 * 4. 1211
                 * 5. 2111
                 * 6. 212
                 * 7. 221
                 * 8. 122
                 */
                N = 5,
                Expectation = 8
            },
            new ClimbingStairsExpectations
            {
                /*
                 1. 111111 - (all 1's)remove 1 1, add 2
                 2. 11112 - bump
                 3. 11121 - bump
                 4. 11211 - bump
                 5. 12111 - bump
                 6. 21111 - all 2's forward. reverse, remove 1 1, add 2
                 7. 1122  - hit a 2.  bump and start over
                 8. 1212  - bump 
                 9. 1221  - hit a 2.  bump and start over 
                10. 2112  - bump 
                11. 2121  - bump 
                12. 2211  - all 2's forward. reverse, remove 1 1, add 2
                13. 222
                
                */
                N = 6,
                Expectation = 13
            },
            new ClimbingStairsExpectations
            {
                /*
                 1. 1111111 - (all 1's)remove 1 1, add 2
                 2. 111112 - bump
                 3. 111121 - bump
                 4. 111211 - bump
                 5. 112111 - bump
                 6. 121111 - bump
                 7. 211111 - all 2's forward. reverse, remove 1 1, add 2 
                 8. 11122 - hit a 2.  bump and start over 
                 9. 11212 - bump
                10. 11221 - hit a 2.  bump and start over
                11. 12112 - bump
                12. 12121 - bump
                13. 12211 - hit a 2. bump and start over
                14. 21112 - bump
                15. 21121 - bump
                16. 21211 - bump
                17. 22111 - all 2's forward. reverse, remove 1 1, add 2
                18. 1222 - hit a 2, bump and start over
                19. 2122 - hit a 2, bump and start over
                20. 2212 - bump
                21. 2221
                */
                N = 7,
                Expectation = 21
            },
            new ClimbingStairsExpectations
            {
                N = 8,
                Expectation = 34
            },
            new ClimbingStairsExpectations
            {
                N = 9,
                Expectation = 55
            },
            new ClimbingStairsExpectations
            {
                N = 19,
                Expectation = 6765
            },
        };
        
        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(ClimbingStairsExpectations testCase)
        {
            // Arrange
            var solution = new Solution();
            var solution2 = new Solution2();

            // Act
            var result = solution.ClimbStairs(testCase.N);
            var result2 = solution2.ClimbStairs(testCase.N);

            // Assert
            result.Should().Be(testCase.Expectation);
            result2.Should().Be(testCase.Expectation);

            Console.WriteLine("0070 climbing-stairs tests Success!");
        }
    }
}