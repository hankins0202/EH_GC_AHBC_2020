﻿using System;
namespace W10D3_TDDExample_FizzBuzz
{
    public class FizzBuzz
    {
        public string Generate(int input)
        {
            var result = string.Empty;
            if(input % 5 == 0 && input % 3 == 0)
            {
                result =  "FizzBuzz";
            }
            else if (input % 3 == 0)
            {
                result =  "Fizz";
            }
            else
            {
                result =  "Buzz";
            }
            return result;
        }
    }
}
