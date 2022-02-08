using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ExcelSheetColumnNumber
{
    public class ExcelSheetColumnNumberTest
    {
        public class TestCase
        {
            public string ColumnTitle { get; set; }
            public int Expectation { get; set; }
        }

        private static object[] _testCaseData = {
            
            new TestCase { ColumnTitle = "A", Expectation = 1},
            new TestCase { ColumnTitle = "Z", Expectation = 26},
            new TestCase { ColumnTitle = "AA", Expectation = 27},
            new TestCase { ColumnTitle = "AZ", Expectation = 52},
            new TestCase { ColumnTitle = "BA", Expectation = 53},
            new TestCase { ColumnTitle = "ZY", Expectation = 701},
            new TestCase { ColumnTitle = "ZZ", Expectation = 702},
            new TestCase { ColumnTitle = "AAA", Expectation = 703},
        }; 

        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(TestCase testCase)
        {
            // Arrange
            var solution = new Solution();
            
            // Act
            var result = solution.TitleToNumber(testCase.ColumnTitle);
            
            // Assert
            result.Should().Be(testCase.Expectation);
            Console.WriteLine("0171 excel-sheet-column-number tests Success!");
        }

    }
}