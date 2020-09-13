using System;
namespace ROSHAMBO
{
    public class InputService
    {

        public RPS Play(RPS input, RPS input1)
        {
            if (input.Equals(RPS.Paper) && input1.Equals(RPS.Rock))
                return RPS.Paper;
            else if (input1.Equals(RPS.Scissors))
                return RPS.Scissors;
            else
                return RPS.Rock;
        }
    }
}
