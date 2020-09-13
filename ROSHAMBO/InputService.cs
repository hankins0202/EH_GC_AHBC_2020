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
            else 
                return RPS.Inconclusive;
        }
    }
}
