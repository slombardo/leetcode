using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
				
public class MatrixExpectations{
	public int[][] Matrix {get; set;}
	public int[] Expectation {get; set;}
}

public class Program{
	public static void Main()
	{
		// Arrange
		var testCases = new MatrixExpectations[] {
            new()
            {
                Matrix = new[]
                {
                    new[] {1,2,3},
                    new[] {4,5,6},
                    new[] {7,8,9}
                },
                Expectation = new[] {1,2,3,6,9,8,7,4,5}
            },
            new()
            {
                Matrix = new[]
                {
                    new[] {1,2,3,4},
                    new[] {5,6,7,8},
                    new[] {9,10,11,12}
                },
                Expectation = new[]{1,2,3,4,8,12,11,10,9,5,6,7}
            },
            new()
            {
                Matrix = new []
                {
                    new[] {1,2,3,4},
                    new[] {4,5,6,7},
                    new[] {7,8,9,10}
                },
                Expectation = new[]{1,2,3,4,7,10,9,8,7,4,5,6}
            },
		};
		var solution  = new Solution();
		
		// Act
		var result1 = solution.SpiralOrder(testCases[0].Matrix);
		var result2 = solution.SpiralOrder(testCases[1].Matrix);
		var result3 = solution.SpiralOrder(testCases[2].Matrix);
		
		// Assert
		result1.Should().BeEquivalentTo(testCases[0].Expectation);
		result2.Should().BeEquivalentTo(testCases[1].Expectation);
		result3.Should().BeEquivalentTo(testCases[2].Expectation);
		
		Console.WriteLine("Success!");
	}
}

public class Solution {	
	
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();
        
        int x = -1;
        int y = 0;
        
        var columnCount = matrix.First().Count();
        var rowCount = matrix.Count();
        var yMin = 0;
        var yMax = rowCount -1;
        var xMin = 0;
        var xMax = columnCount -1;
        var direction = Direction.Right;
        
        while (result.Count < rowCount * columnCount)
        {
            MoveNext(ref x, ref y, direction);
            
            result.Add(matrix[y][x]);
            
            if(x == xMax && y == yMin && direction == Direction.Right) yMin++;
            else if(x == xMax && y == yMax && direction == Direction.Down) xMax--;
            else if(x == xMin && y == yMax && direction == Direction.Left) yMax--;
            else if(x == xMin && y == yMin && direction == Direction.Up) xMin++;
            else continue;

            direction = (Direction)(((int)direction + 1) % 4);
        }
        
        return result;
    }
    
    private void MoveNext(ref int x, ref int y, Direction direction)
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

    private enum Direction{
        Right,
        Down,
        Left,
        Up,        
    }
}
