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
            RPS input1 = RPS.Scissors;
            RPS expectedResult = RPS.Rock;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void ScissorsBeatsPaperTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Scissors;
            RPS input1 = RPS.Paper;
            RPS expectedResult = RPS.Scissors;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void RockLosesToPaperTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Rock;
            RPS input1 = RPS.Paper;
            RPS expectedResult = RPS.Paper;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void ScissorsLosesToRockTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Scissors;
            RPS input1 = RPS.Rock;
            RPS expectedResult = RPS.Rock;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void PaperLosesToScissorsTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Paper;
            RPS input1 = RPS.Scissors;
            RPS expectedResult = RPS.Scissors;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void PaperTieTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Paper;
            RPS input1 = RPS.Paper;
            RPS expectedResult = RPS.Tie;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void ScissorsTieTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Scissors;
            RPS input1 = RPS.Scissors;
            RPS expectedResult = RPS.Tie;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void RockTieTest()
        {
            //Arrange
            var inputService = new InputService();
            RPS input = RPS.Rock;
            RPS input1 = RPS.Rock;
            RPS expectedResult = RPS.Tie;

            //Act
            RPS result = inputService.Play(input, input1);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void UserInputStringTest()
        {
            //Arrange
            var inputService = new InputService();
            string input = "D";
            bool expectedResult = false;

            //Act
            bool result = inputService.ValidateUserInput(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void UserInputInValid01Or2Test()
        {
            //Arrange
            var inputService = new InputService();
            string input = "9";
            bool expectedResult = false;

            //Act
            bool result = inputService.ValidateUserInput(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
        [Fact]
        public void UserInputValid01Or2Test()
        {
            //Arrange
            var inputService = new InputService();
            string input = "2";
            bool expectedResult = true;

            //Act
            bool result = inputService.ValidateUserInput(input);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
