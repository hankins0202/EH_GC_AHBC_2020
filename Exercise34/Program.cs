using System;

namespace Exercise34
{
    class Program
    {
        static void Main(string[] args)
        {
        int[] numArray = new int[] { 16, 32, 64, 128, 256 };
        bool continueYesNo = true;
        do {
                Console.WriteLine("Enter a command (half/double)");
                string UserCommand = Console.ReadLine();


                if (UserCommand.ToLower() == "half")
                {
                    returnsHalfValue(numArray);
                    
                }
                else if (UserCommand.ToLower() == "double")
                {
                    returnsDoubleValue(numArray);
                }
                else
                {
                    Console.Write("Invalid entery.");
                }

            } while (continueYesNo);
        }

        static void returnsHalfValue(int[] numArray)
        {
            Console.Write("The array now contains: ");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = numArray[i] / 2;
                Console.Write($"{numArray[i]}, ");
            }
        }

        static void returnsDoubleValue(int[] numArray)
        {
            Console.Write("The array now contains: ");
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = numArray[i] * 2;
                Console.Write($"{numArray[i]}, ");
            }
        }
    }
}
