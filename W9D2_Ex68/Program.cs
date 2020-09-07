using System;
using System.Collections.Generic;

namespace W9D2_Ex68
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> spanishTranslator = new Dictionary<string, string>()
            {
                {"Hello", "Hola" },
                {"Food","Comida"},
                {"World", "Mundo" },
                {"Computer", "Computadora" },
                {"Exercise", "Ejercicio" },
            };

            Console.WriteLine("Enter a word in English");
            string userWord = Console.ReadLine();

            if(spanishTranslator.TryGetValue(userWord, out string translatedWord))
            {
                Console.WriteLine($"{userWord} is {translatedWord} in spanish.");
            }
            else
            {
                Console.WriteLine($"{userWord} cannot be translated");
            }

            Console.WriteLine(spanishTranslator.Keys);//prints all keys
            var keys = spanishTranslator.Keys;
            var values = spanishTranslator.Values;
            Console.WriteLine(values);//foreach loop to print entire dictionary
            foreach (var key in collection)
            {

            }
        }
    }
}
