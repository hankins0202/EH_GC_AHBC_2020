using System;
using W10D3_TDDExample_FizzBuzz;
using Xunit;

namespace W10D3_TDDExample_FizzBuzzTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldReturnFizzForMultipleOFThree()
        {
            //Arrange
            var input = 3;
            var expectedResult = "Fizz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string result = fizzBuzz.Generate(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void ShouldReturnBuzzForMultiplesOfFives()
        {
            //Arrange
            var input = 5;
            var expectedResult = "Buzz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string result = fizzBuzz.Generate(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void ShouldReturnFizzBuzzForMultiplesOfThreesAndFives()
        {
            //Arrange
            var input = 15;
            var expectedResult = "FizzBuzz";
            FizzBuzz fizzBuzz = new FizzBuzz();

            //Act
            string result = fizzBuzz.Generate(input);

            //Assert
            Assert.Equal(expectedResult, result);

        }
    }
}
