﻿using System;
namespace Week3Day2Review
{
    public class Assessment1b
    {
        public Assessment1b()
        {
            var VowelTest = IsVowel('y');
            var CountVowelTest = CountVowels("Avengers");
            var vowelShame = TooManyVowels("Avengers");

            Console.WriteLine(VowelTest);
            Console.WriteLine(CountVowelTest);
            Console.WriteLine(vowelShame);

            static bool IsVowel(char vowel)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    return true;
                }
                return false;
            }

            static int CountVowels(string sentance)
            {
                
                int vowelCount = 0;
                foreach (var character in sentance)
                {
                    if(character.Equals('a') || character.Equals('e') || character.Equals('i') || character.Equals('o') || character.Equals('u'))
                    {
                        return vowelCount++;
                    }
                }
                return 0;
            }

            static string TooManyVowels(string sentance)
            {
                if(CountVowels(sentance)<=4)
                {
                    return "few vowels";
                }
                else if ((CountVowels(sentance) >= 5) && (CountVowels(sentance))<= 7)
                {
                    return "right amount of vowels";
                }
                else if (CountVowels(sentance) >= 8)
                {
                    return "too many vowels";
                }
                return "What is a vowel";
            }


        }
    }
}
