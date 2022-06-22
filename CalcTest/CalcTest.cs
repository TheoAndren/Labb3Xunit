using System;
using Xunit;
using Labb3Xunit;
using System.Collections.Generic;

namespace CalculatorTest
{
    public class CalcTest
    {
        [Fact]
        [Trait("Category", "Addition")]
        public void Add_1_And_4_Return_5_AdditionTest()
        {
            // Assert
            int num1 = 1;
            int num2 = 4;
            var expected = 5;

            // Act
            var actual = Calculator.Addition(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Addition")]
        [InlineData(54, 50, 104)]
        [InlineData(13, 37, 50)]
        [InlineData(6, -2, 4)]
        [InlineData(-7, 7, 0)]
        [InlineData(1.5, 0, 1.5)]
        public void AdditionTest_With_Multiple_Inputs(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Addition(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "Subtraction")]
        public void Subtract_7_From_14_Return_7_SubtractionTest()
        {
            // Assert
            int num1 = 14;
            int num2 = 7;
            var expected = 7;

            // Act
            var actual = Calculator.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Subtraction")]
        [InlineData(80, 25, 55)]
        [InlineData(55, -25, 80)]
        [InlineData(-60, -60, 0)]
        [InlineData(0, -89, 89)]
        [InlineData(142, 142, 0)]
        public void SubtractionTest_With_Multiple_Inputs(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Subtraction(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);

        }

        [Fact]
        [Trait("Category", "Divison")]
        public void Divide_100_With_5_Return_20_DivisionTest()
        {
            // Assert
            int num1 = 100;
            int num2 = 5;
            var expected = 20;

            // Act
            var actual = Calculator.Division(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Divison")]
        [InlineData(40, 4, 10)]
        [InlineData(10, 2, 5)]
        [InlineData(6, 5, 1.2)]
        [InlineData(-20, 10, -2)]
        [InlineData(82, 4, 20.5)]
        public void DivisionTest_With_Multiple_Inputs(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Division(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "Multiplication")]
        public void Multiply_18_With_9_Return_162_MultiplicationTest()
        {
            // Assert
            int num1 = 18;
            int num2 = 9;
            var expected = 162;

            // Act
            var actual = Calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Multiplication")]
        [InlineData(1, 1, 1)]
        [InlineData(10, 4, 40)]
        [InlineData(7.4, 7.1, 52.54)]
        [InlineData(0, 3, 0)]
        [InlineData(5, 39, 195)]
        public void MultiplicationTest_With_Multiple_Inputs(decimal num1, decimal num2, decimal expectedResult)
        {
            // Act
            var actual = Calculator.Multiplication(num1, num2);

            // Assert
            Assert.Equal(expectedResult, actual);
        }

        [Fact]
        [Trait("Category", "User input")]
        public void UserInput_String_Return_Decimal()
        {
            // Arrange
            string testInput = "8,4";

            // Act
            var actual = Calculator.UserInput(testInput);

            // Assert
            Assert.IsType<decimal>(actual);
        }

        [Theory]
        [Trait("Category", "User input")]
        [InlineData("7,1", 7.1)]
        [InlineData("-342", -342)]
        [InlineData("0,1", 0.1)]
        [InlineData("-0,8", -0.8)]
        [InlineData("0", 0)]
        public void UserInputTest_With_Multiple_Inputs(string testinput, decimal expectedResult)
        {
            // Act + Assert
            Assert.Equal(expectedResult, Calculator.UserInput(testinput));
        }

        [Fact]
        [Trait("Category", "Print result")]
        public void PrintResult_10_Divided_By_2_Is_5()
        {
            // Arrange
            decimal testNum1 = 10;
            decimal testNum2 = 2;
            decimal calculationResult = 5;
            string calcType = "/";
            var expected = "10 / 2 = 5";

            // Act
            var actual = Calculator.PrintResult(testNum1, testNum2, calculationResult, calcType);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [Trait("Category", "Print result")]
        [InlineData(142, 11, 153, "+", "142 + 11 = 153")]
        [InlineData(100, 100, 0, "-", "100 - 100 = 0")]
        [InlineData(0, 4, 0, "*", "0 * 4 = 0")]
        [InlineData(-60, -60, 0, "-", "-60 - -60 = 0")]
        [InlineData(100, 5, 20, "/", "100 / 5 = 20")]
        public void PrintResultTest_With_Multiple_Inputs(decimal num1, decimal num2, decimal calculationResult, string calcType, string expectedResult)
        {
            // Act + Assert
            Assert.Equal(expectedResult, Calculator.PrintResult(num1, num2, calculationResult, calcType));
        }

        [Fact]
        [Trait("Category", "Print all calculations")]
        public void PrintAllCalculations_Return_4_Calculations()
        {
            // Arrange
            List<string> testList = new List<string>() { "1 + 1 = 2",
                "4 - 2 = 2",
                "20 / 2 = 10",
                "10 * 10 = 100" };
            var expected = 4;

            // Act
            var actual = Calculator.PrintAllCalculations(testList);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}