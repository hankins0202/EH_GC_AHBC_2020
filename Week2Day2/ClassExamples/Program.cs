using System;

namespace ClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi" + "Elizabeth");//using addition symbol +

            var somethingfunky = string.Concat("He", "Low");//concatenation
            Console.WriteLine(somethingfunky);

            Console.WriteLine($"Here is {somethingfunky}"); //interprelation
            //criticize the code not the person

            //split
            var sidSpeaks = "Sid, has a nice voice, great"; //breaks strings into array via specified character delimited.
            var sidSpeaksSplit = sidSpeaks.Split(',');

            //[sid, has a nice voice, great]
            // 0        1               2
            for (int i = 0; i < sidSpeaksSplit.Length; i++)//double tab. 
            {
                //Console.WriteLine(sidSpeaksSplit[i]);//[] accesses elements in array. in this case the string is an array
                Console.WriteLine($"Index{i}:{sidSpeaksSplit}");
            }

            // Whitespace example
            string whiteSpace = "      hello          world    ";
            Console.WriteLine(whiteSpace.Trim());
            //vb and C# share a lot of the librairies with similar function. Crossover between "functions" but not all.

            //name = name.Replace(" ","");
            Console.WriteLine(whiteSpace.Replace(" ", ""));

            //User input from console. String Comparison

            var userInput = Console.ReadLine();
            if (userInput.Equals("KORI", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("It is equal");
            }

        }
    }
}
