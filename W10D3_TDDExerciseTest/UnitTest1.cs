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

            Calculator calculator = new Calculator();
            
            int expectedResult = 8;

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

            Calculator calculator = new Calculator();

            int expectedResult = 7;

            //Act
            int result = calculator.Subtraction(input1, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
