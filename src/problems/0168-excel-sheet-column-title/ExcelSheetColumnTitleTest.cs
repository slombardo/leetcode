using System;
using FluentAssertions;
using NUnit.Framework;

namespace leetcode.problems.ExcelSheetColumnTitle
{
    public class ExcelSheetColumnTitleTest
    {
        public class TestCase
        {
            public int ColumnNumber { get; set; }
            public string Expectation { get; set; }
        }

        private static object[] _testCaseData = {
            
            new TestCase { ColumnNumber = 1, Expectation = "A"},
            new TestCase { ColumnNumber = 26, Expectation = "Z"},
            new TestCase { ColumnNumber = 27, Expectation = "AA"},
            new TestCase { ColumnNumber = 52, Expectation = "AZ"},
            new TestCase { ColumnNumber = 53, Expectation = "BA"},
            new TestCase { ColumnNumber = 701, Expectation = "ZY"},
            new TestCase { ColumnNumber = 702, Expectation = "ZZ"},
            new TestCase { ColumnNumber = 703, Expectation = "AAA"},
        }; 

        [Test, TestCaseSource(nameof(_testCaseData))]
        public static void RunTests(TestCase testCase)
        {
            // Arrange
            var solution = new Solution();
            
            // Act
            var result = solution.ConvertToTitle(testCase.ColumnNumber);
            
            // Assert
            result.Should().BeEquivalentTo(testCase.Expectation);
            Console.WriteLine("0168 excel-sheet-column-title tests Success!");
        }

    }
}