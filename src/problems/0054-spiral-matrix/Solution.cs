using System.Collections.Generic;
using System.Linq;

namespace leetcode.problems.SpiralMatrix
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>();

            var x = -1;
            var y = 0;

            var columnCount = matrix.First().Count();
            var rowCount = matrix.Count();
            var yMin = 0;
            var yMax = rowCount - 1;
            var xMin = 0;
            var xMax = columnCount - 1;
            var direction = Direction.Right;

            while (result.Count < rowCount * columnCount)
            {
                MoveNext(ref x, ref y, direction);

                result.Add(matrix[y][x]);

                if (x == xMax && y == yMin && direction == Direction.Right) yMin++;
                else if (x == xMax && y == yMax && direction == Direction.Down) xMax--;
                else if (x == xMin && y == yMax && direction == Direction.Left) yMax--;
                else if (x == xMin && y == yMin && direction == Direction.Up) xMin++;
                else continue;

                direction = (Direction) (((int) direction + 1) % 4);
            }

            return result;
        }

        private static void MoveNext(ref int x, ref int y, Direction direction)
        {
            switch (direction)
            {
                case Direction.Right:
                    x++;
                    break;
                case Direction.Down:
                    y++;
                    break;
                case Direction.Left:
                    x--;
                    break;
                case Direction.Up:
                    y--;
                    break;
            }
        }

        private enum Direction
        {
            Right,
            Down,
            Left,
            Up,
        }
    }
}