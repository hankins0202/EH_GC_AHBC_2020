using System;
using Xunit;
using W10D3_TDDExercise;

namespace W10D3_TDDExerciseCalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void CalculatorShouldAddNumbersTogether()
        {
            //Arrange
            int input1 = 3;
            int input2 = 5;
            int expectedResult = 8;
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Addition(input1, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CalculatorShouldSubtractNumbersTogether()
        {
            //Arrange
            int input1 = 10;
            int input2 = 3;
            int expectedResult = 7;

            Calculator calculator = new Calculator();

            

            //Act
            int result = calculator.Subtraction(input1, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CalculatorShouldMultiplyNumbersTogether()
        {
            //Arrange
            int input1 = 3;
            int input2 = 5;
            int expectedResult = 15;
            Calculator calculator = new Calculator();

            //Act
            int result = calculator.Multiplication(input1, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
