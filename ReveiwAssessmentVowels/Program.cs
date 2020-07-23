using System;
namespace Week3Day2Review
{
    public class Assessment1b
    {
     

            static void Main(string[] args)
            {
                var VowelTest = IsVowel('y');
                var CountVowelTest = CountVowels("This is a test to see if we have too many vowels, AEIOU");
                var vowelShame = TooManyVowels("This is a test to see if we have too many vowels, AEIOU");

                Console.WriteLine(VowelTest);
                Console.WriteLine(CountVowelTest);
                Console.WriteLine(vowelShame);
            }
            public static bool IsVowel(char vowel)
            {
                if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
                {
                    return true;
                }
                return false;
            }

            public static int CountVowels(string sentance)
            {

                int vowelCount = 0;
                foreach (char character in sentance.ToLower())
                {
                    if (character.Equals('a') || character.Equals('e') || character.Equals('i') || character.Equals('o') || character.Equals('u'))
                    {
                       vowelCount++;
                    }
                }
            return vowelCount;
            }

            public static string TooManyVowels(string sentance)
            {
                if (CountVowels(sentance) <= 4)
                {
                    return "few vowels";
                }
                else if ((CountVowels(sentance) >= 5) && (CountVowels(sentance)) <= 7)
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
