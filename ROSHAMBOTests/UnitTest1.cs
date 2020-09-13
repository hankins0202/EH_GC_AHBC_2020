using System;
using ROSHAMBO;
using Xunit;

namespace ROSHAMBOTests
{
    public class UnitTest1
    {
        [Fact]
        public void PaperBeatsRockTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Paper;
            RPS input1 = RPS.Rock;
            RPS expectedResult = RPS.Paper;

            //Act
            RPS result = inputService.Play(input,input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void RockBeatsScissorsTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Rock;
            RPS input2 = RPS.Scissors;
            RPS expectedResult = RPS.Rock;

            //Act
            RPS result = inputService.Play(input, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void ScissorsBeatsPaperTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Scissors;
            RPS input2 = RPS.Paper;
            RPS expectedResult = RPS.Scissors;

            //Act
            RPS result = inputService.Play(input, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
