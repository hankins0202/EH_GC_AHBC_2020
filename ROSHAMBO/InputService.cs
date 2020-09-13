using System;
namespace ROSHAMBO
{
    public class InputService
    {

        public RPS Play(RPS input, RPS input1)
        {
            RPS result = new RPS();
            switch (input)
            {
                case RPS.Paper:
                    if (input1.Equals(RPS.Rock))
                        result = RPS.Paper;
                    else
                        result =  RPS.Scissors;
                    break;
                case RPS.Rock:
                    if (input1.Equals(RPS.Scissors))
                        result =  RPS.Rock;
                    else
                        result =  RPS.Paper;
                    break;
                case RPS.Scissors:
                    if (input1.Equals(RPS.Paper))
                        result =  RPS.Scissors;
                    else
                        result =  RPS.Rock;
                    break;
            }
            return result;

            //if (input.Equals(RPS.Paper) && input1.Equals(RPS.Rock))
            //    return RPS.Paper;
            //else if (input.Equals(RPS.Rock) && input1.Equals(RPS.Scissors))
            //    return RPS.Rock;
            //else if (input.Equals(RPS.Scissors) && input1.Equals(RPS.Paper))
            //    return RPS.Scissors;
            //else if (input.Equals(RPS.Rock) && input1.Equals(RPS.Paper))
            //    return RPS.Paper;
            //else if (input.Equals(RPS.Scissors) && input1.Equals(RPS.Rock))
            //    return RPS.Rock;
            //else
            //    return RPS.Inconclusive;
        }
    }
}
