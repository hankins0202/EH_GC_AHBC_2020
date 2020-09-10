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
    }
}
