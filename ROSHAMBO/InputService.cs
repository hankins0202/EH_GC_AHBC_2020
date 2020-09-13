using System;
namespace ROSHAMBO
{
    public class InputService
    {

        public RPS Play(RPS input, RPS input1)
        {
            if (input.Equals(RPS.Paper))
                return RPS.Paper;
            else
                return RPS.Scissors;
        }
    }
}
