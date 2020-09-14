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
                    else if (input1.Equals(RPS.Scissors))
                        result = RPS.Scissors;
                    else
                        result = RPS.Tie;
                    break;
                case RPS.Rock:
                    if (input1.Equals(RPS.Scissors))
                        result = RPS.Rock;
                    else if (input1.Equals(RPS.Paper))
                        result = RPS.Paper;
                    else
                        result = RPS.Tie;
                    break;
                case RPS.Scissors:
                    if (input1.Equals(RPS.Paper))
                        result =  RPS.Scissors;
                    else if (input1.Equals(RPS.Rock))
                        result =  RPS.Rock;
                    else
                        result = RPS.Tie;
                    break;
                default:
                    break;
            }
            return result;
      
        }

        public bool ValidateUserInput(string input)
        {
            try
            {
                if (int.Parse(input) <= 2 && int.Parse(input) >= 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
