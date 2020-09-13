using System;
namespace ROSHAMBO
{
    public class InputService
    {

        public RPS Play(RPS input, RPS input1)
        {
            if (input.Equals(RPS.Paper) && input1.Equals(RPS.Rock))
                return RPS.Paper;
            else if (input.Equals(RPS.Rock) && input1.Equals(RPS.Scissors))
                return RPS.Rock;
            else if (input.Equals(RPS.Scissors) && input1.Equals(RPS.Paper))
                return RPS.Scissors;
            else if (input.Equals(RPS.Rock) && input1.Equals(RPS.Paper))
                return RPS.Paper;
            else
                return RPS.Inconclusive;
        }
    }
}
