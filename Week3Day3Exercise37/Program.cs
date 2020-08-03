using System;

namespace Week3Day3Exercise37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number:");
            int num5 = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[] { num1, num2, num3, num4, num5 };
            var sumArray = arrayOne;
            SumNumbers(arrayOne);

            Console.WriteLine($"{num1}+{num2}+{num3}+{num4}+{num5}={Sum}");

        }

        static int SumNumbers(int[] sumArray, int sum)
        {
            for (int i = 0; i < sumArray.Length; i++)
            {
                return i + i;
            }
        }
    }
}
