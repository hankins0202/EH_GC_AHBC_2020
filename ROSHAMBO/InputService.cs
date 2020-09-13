using System;
namespace ROSHAMBO
{
    public class InputService
    {

        public string Play(string input, string input2)
        {
            if (input.Equals("Rock") && input2.Equals("Paper"))
                return "Paper";
            else
                return "Error";
        }
    }
}
