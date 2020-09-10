using System;
namespace W10D3_TDDExample_FizzBuzz
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Generate(int input)
        {
            if (input % 5 == 0)
                return "Buzz";
            else
            return "Fizz";
        }
    }
}
