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
        public void ScissorsBeatsPaper()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Paper;
            RPS input2 = RPS.Scissors;
            RPS expectedResult = RPS.Scissors;


            //Act
            RPS result = inputService.Play(input, input2);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
