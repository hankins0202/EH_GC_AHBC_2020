using System;

namespace W9D3_Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while(input != "N")
            {
                Console.WriteLine("Enter a whole number");
                int userInput = int.Parse(Console.ReadLine());
                AlternateDeterminePrimeNumber(userInput);

                Console.WriteLine("Do you want to continue? Y/N");
                input = Console.ReadLine().ToUpper();
            }
        }

        public static void AlternateDeterminePrimeNumber(int n)
        {
            int i, m=0, flag = 0;
            m = n / 2;
            for (i = 2; i < m; i++)
            {
                if(n%i == 0)
                {
                    Console.WriteLine("Number is not prime.");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                Console.WriteLine("Number is prime.");
            }
        }
    }
}
//public static void DeterminePrimeNumber(int userInput)
//{
//    for (int i = 2; i < userInput; i++)
//    {
//       if (userInput % i == 0)
//        {
//            Console.WriteLine($"{userInput} is not a prime number");
//            continue;
//        }
//        else
//        {
//            Console.WriteLine($"{userInput} is a prime number");
//            break;
//        }
//    }
//}
