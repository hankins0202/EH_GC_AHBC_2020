using System;
using ROSHAMBO;
using Xunit;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        [Fact]
        public void RockPaperScissorsTests()
        {
            //Arrange
            var inputService = new InputService();
            string input = "Rock";
            string input2 = "Paper";
            string expectedResult = "Paper";


            //Act
            string result = inputService.Play(input,input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
